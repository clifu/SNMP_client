using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Sockets;

namespace SnmpClient
{
    public partial class Form1 : Form
    {

        List<ExtensionDictionary> listValue = new List<ExtensionDictionary>();
        Dictionary<string, string> mibElementsDictionary;
        SNMP_Agent snmp_agent;
        IPAddress IP;
        int i = 5;
        Task monitor;
        Form1 _Application;
        static CancellationTokenSource ts = new CancellationTokenSource();
        CancellationToken ct = ts.Token;
        bool run = true;
        bool runTrap;
        TrapAgent trapAgent;
        bool isNotBindedPort = true;
        Socket socket;

        public Form1()
        {

            InitializeComponent();
            _Application = this;

            snmp_agent = new SNMP_Agent("127.0.0.1", "public");
            IP = IPAddress.Parse("127.0.0.1");
            AddressTextBox.ReadOnly = true;

            OperationsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationsComboBox.Items.Add("Get");
            OperationsComboBox.Items.Add("Get Next");
            OperationsComboBox.Items.Add("Get Table");
            AddressTextBox.Text = "localhost";
            stopReciverToolStripMenuItem.Enabled = false;


            imageList.Images.Add(Properties.Resources.Folder);
            imageList.Images.Add(Properties.Resources.key);
            imageList.Images.Add(Properties.Resources.entry);
            imageList.Images.Add(Properties.Resources.listek);
            imageList.Images.Add(Properties.Resources.paper);
            imageList.Images.Add(Properties.Resources.table);

            mibElementsDictionary = new Dictionary<string, string>();
            loadMibTreeElements();

            initiationTrapSender();


            trapAgent = new TrapAgent();

        }

        public void initiationTrapSender()
        {
            textBoxTSAddress.Text = "127.0.0.1";
            textBoxTSCommunity.Text = "public";
            textBoxTSPort.Text = "162";

            comboBoxTSGeneric.Items.Add("ColdStart");
            comboBoxTSGeneric.Items.Add("WarmStart");
            comboBoxTSGeneric.Items.Add("LinkDown");
            comboBoxTSGeneric.Items.Add("LinkUp");
            comboBoxTSGeneric.Items.Add("AuthenticationFailure");
            comboBoxTSGeneric.Items.Add("EGPNeithbourLoss");
            comboBoxTSGeneric.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void addRowToResultsTable(string OID, string value, string type, string IP)
        {
            dataGridView1.Rows.Add(OID, value, type, IP);
        }

        //
        public void addRowToGetTableResultsTable(string[] columns)
        {
            dataGridView2.Rows.Add(columns);
        }

        public void addRowToAgentNotify(string address, string name, string value, DateTime time, int generic)
        {
            string genericName = "";
            switch (generic)
            {
                case 0:
                    genericName = "ColdStart";
                    break;
                case 1:
                    genericName = "WarmStart";
                    break;
                case 2:
                    genericName = "LinkDown";
                    break;
                case 3:
                    genericName = "LinkUp";
                    break;
                case 4:
                    genericName = "AuthenticationFailure";
                    break;
                case 5:
                    genericName = "EGPNeithbourLoss";
                    break;
            }
            _Application.richTextBox1.Invoke(new Action(delegate ()
            {
                dataGridView3.Rows.Add(address, name, value, time,genericName);
            }));
        }

        public void addRowToAgentNotify(string address, string name, string value, DateTime time, string generic)
        {
            
           
            _Application.richTextBox1.Invoke(new Action(delegate ()
            {
                dataGridView3.Rows.Add(address, name, value, time, generic);
            }));
        }

        private void loadMibTreeElements()
        {
            treeView.Nodes.Add("iso.org.dod.internet.mgmt.mib-2");

            var input_path = Properties.Resources.mibTreeElements;
            string[] lineSplit;
            List<TreeNode> treeNodeList = new List<TreeNode>();
            treeNodeList.Add(treeView.Nodes[0]);
            string OID; // OID
            string key; // nazwa 
            string type; //typ

            string[] dd = input_path.Split('\n');
            string line;

            int length;

            for (int i = 0; i < dd.Length; i++)
            {
                line = dd[i];
                lineSplit = line.Split('#');
                OID = "." + lineSplit[1];
                key = lineSplit[2];
                type = lineSplit[3];
                mibElementsDictionary.Add(key, OID);
                listValue.Add(new ExtensionDictionary(key, OID, type));


                length = Int32.Parse(lineSplit[4]);
                if (treeNodeList.Count > length)
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList[length] = treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1];
                    treeNodeList[length].ImageIndex = 1;
                }
                else
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList.Add(treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1]);
                }

                // Dodanie obrazków
                switch (lineSplit[0])
                {
                    case "F":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 0;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 0;
                        break;
                    case "L":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 3;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 3;
                        break;
                    case "P":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 4;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 4;
                        break;
                    case "E":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 2;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 2;
                        break;
                    case "T":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 5;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 5;
                        break;
                    case "K":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 1;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 1;
                        break;
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string value;
            /*if (mibElementsDictionary.TryGetValue(treeView.SelectedNode.Text, out value))
                OIDTextBox.Text = value;*/
            DataStore? dataStore = FindRow(treeView.SelectedNode.Text);
            if (dataStore != null)
            {

                OIDTextBox.Text = dataStore.Value.value;
            }
        }

        private void OperationsComboBox_StyleChanged(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //string address = AddressTextBox.Text;
            string OID = OIDTextBox.Text;
            string option = OperationsComboBox.Text;
            string type = string.Empty; //syntax
            string name = string.Empty; //object name
            string value = string.Empty;
            DataStore? dataStore;
            string ttt;




            switch (option)
            {
                case "Get":

                    ttt = findLongestTrunk(listValue, OID);
                    dataStore = FindRowOID(ttt);
                    if (dataStore != null)
                    {

                        type = dataStore.Value.type;
                        name = dataStore.Value.value;

                        if (name == "system" || name == "interfaces" || name == "at" || name == "ip" || name == "icmp"
                            || name == "tcp" || name == "udp" || name == "egp" || name == "snmp" || name == "host")
                        {
                            name = OIDTextBox.Text;
                            type = string.Empty;
                        }
                    }

                    var result = snmp_agent.GetRequest(SnmpVersion.Ver2, OID, IP);


                    value = result.Pdu.VbList[0].Value.ToString();


                    // result.Pdu.
                    // get();
                    if (value == "Null" || value == "NULL" || value == "null")
                    {
                        //result = snmp_agent.GetNextRequest(SnmpVersion.Ver2, OID, IP);
                        //OIDTextBox.Text = result.Pdu.VbList[0].Oid.ToString();
                        MessageBox.Show("No such name error(127.0.0.1)", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //result = snmp_agent.GetNextRequest(SnmpVersion.Ver2, OID, IP);
                        //OIDTextBox.Text = result.Pdu.VbList[0].Oid.ToString();
                    }
                    else
                    {
                        addRowToResultsTable(name, value, type, IP.ToString());
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                    }
                    break;
                case "Get Next":



                    var resultNext = snmp_agent.GetNextRequest(SnmpVersion.Ver2, OID, IP);
                    value = resultNext.Pdu.VbList[0].Value.ToString();

                    OIDTextBox.Text = "." + resultNext.Pdu.VbList[0].Oid.ToString();
                    ttt = findLongestTrunk(listValue, OIDTextBox.Text);
                    dataStore = FindRowOID(ttt);
                    if (dataStore != null)
                    {

                        type = dataStore.Value.type;
                        name = dataStore.Value.value;

                        if (name == "system" || name == "interfaces" || name == "at" || name == "ip" || name == "icmp"
                            || name == "tcp" || name == "udp" || name == "egp" || name == "snmp" || name == "host")
                        {
                            name = OIDTextBox.Text;
                            type = string.Empty;
                        }
                    }
                    addRowToResultsTable(name, value, type, IP.ToString());
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;

                    break;

                case "Get Table":

                    int lengthRow = dataGridView2.Rows.Count;
                    int lengthColumn = dataGridView2.ColumnCount;
                    for (int i = (lengthRow - 1); i >= 0; i--)
                        dataGridView2.Rows.RemoveAt(i);
                    for (int i = (lengthColumn - 1); i >= 0; i--)
                        dataGridView2.Columns.RemoveAt(i);

                    List<string> nameColumns = new List<string>();
                    nameColumns = getTableColumnName(ref OID);

                    foreach (var column in nameColumns)
                    {
                        dataGridView2.Columns.Add("Column" + i, column);
                        i++;
                    }

                    var dictionary = snmp_agent.GetTableRequest(SnmpVersion.Ver2, OID);

                    List<AsnType> Values = new List<AsnType>();

                    foreach (var key in dictionary)
                    {
                        var dictionary2 = key.Value;

                        foreach (var KEY in dictionary2)
                        {
                            //Dodanie wartosci do listy
                            Values.Add(KEY.Value);
                        }
                    }
                    if (Values.Count > 0)
                    {
                        string[] table = new string[dataGridView2.ColumnCount];
                        dataGridView2.Rows.Add(Values.Count / dataGridView2.ColumnCount);
                        for (int i = 0; i < dataGridView2.ColumnCount; i++)
                        {

                            for (int j = 0; j < Values.Count / dataGridView2.ColumnCount; j++)
                            {
                                int elementAt = i * dataGridView2.Rows.Count + j;
                                dataGridView2.Rows[j].Cells[i].Value = Values.ElementAt(elementAt).ToString();
                            }

                        };
                        dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.Rows.Count - 1;
                    }
                    else
                    {
                        MessageBox.Show("No such name");
                    }

                    //TODO: Stwórz kolumny (z pliku tekstowego wyszukaj nazwy kolumn zaczynając na OID, i ile ich jest, i odpowiednio podziel listę wartości

                    break;
                default:
                    break;

            }

        }

        public DataStore? FindRow(string key)
        {
            DataStore dataStore = new DataStore();
            foreach (var element in listValue)
            {
                if (element.key == key)
                {
                    dataStore.value = element.value;
                    dataStore.type = element.type;
                    return dataStore;

                }

            }
            return null;
        }

        public DataStore? FindRowOID(string value)
        {
            DataStore dataStore = new DataStore();
            foreach (var element in listValue)
            {
                if (element.value == value)
                {
                    dataStore.value = element.key;
                    dataStore.type = element.type;
                    return dataStore;

                }

            }
            return null;
        }

        /// <summary>
        /// Szuka najdluszego dopasowania z listy OIDów
        /// </summary>
        /// <param name="OID_List"></param>
        /// <returns></returns>
        public static string findLongestMatch(string[] OID_List, string trunk)
        {

            StringBuilder PatternBuilder = new StringBuilder(trunk);
            PatternBuilder.Append(@"(.\d+)+");
            PatternBuilder.Append("|");
            PatternBuilder.Append(trunk);

            string longestMatch = "";

            for (int i = 0; i < OID_List.Length; i++)
            {
                var match = Regex.Match(OID_List[i], PatternBuilder.ToString(), RegexOptions.None);

                if (longestMatch.Length < match.Value.Length)
                {
                    longestMatch = match.Value;
                }
            }

            return longestMatch;
        }

        /// <summary>
        /// Funkcja znajdująca najdłuższe dopasowanie w liście wzorców.
        /// </summary>
        /// <param name="OID_List"></param>
        /// <param name="longOID"></param>
        /// <returns></returns>
        public static string findLongestTrunk(List<ExtensionDictionary> OID_List, string longOID)
        {
            StringBuilder PatternBuilder;

            string longestMatch = "";

            for (int i = 0; i < OID_List.Count; i++)
            {
                //Tworzenie kolejnego wzorca z listy
                PatternBuilder = new StringBuilder(OID_List[i].value);
                PatternBuilder.Append(@"(.\d+)+|");
                PatternBuilder.Append(OID_List[i].value);

                string pattern = PatternBuilder.ToString();

                //Dopasowanie longOID do wzorca
                var match = Regex.Match(longOID, pattern, RegexOptions.None);

                //Gdy udalo sie dopasowac i dlugosc dopasowania jest dluzsza, niz najdluzsze dopasowanie, to aktualizujemy
                if (match.Success && OID_List[i].value.Length > longestMatch.Length)
                    longestMatch = OID_List[i].value;
            }

            if (longestMatch != "")
                return longestMatch;
            else
                return null;

        }

        private void OperationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            int lengthRow = dataGridView2.Rows.Count;
            int lengthColumn = dataGridView2.ColumnCount;
            for (int i = (lengthRow - 1); i >= 0; i--)
                dataGridView2.Rows.RemoveAt(i);
            for (int i = (lengthColumn - 1); i >= 0; i--)
                dataGridView2.Columns.RemoveAt(i);
        }

        private List<string> getTableColumnName(ref string oid)
        {
            List<string> nameOfColumns = new List<string>();
            var input_path = Properties.Resources.mibTreeElements;
            string[] lineSplit;

            string OID; // OID
            int numberOfLine = 0;

            string[] dd = input_path.Split('\n');
            string line;



            for (int i = 0; i < dd.Length; i++)
            {

                line = dd[i];
                lineSplit = line.Split('#');
                OID = "." + lineSplit[1];
                if (OID == oid)
                {
                    numberOfLine = i;

                }


            }


            line = dd[numberOfLine];
            lineSplit = line.Split('#');

            if (lineSplit[4].StartsWith("2"))
            {
                line = dd[numberOfLine + 2];
                lineSplit = line.Split('#');
                while (lineSplit[4].StartsWith("4"))
                {

                    nameOfColumns.Add(lineSplit[2]);
                    numberOfLine++;
                    line = dd[numberOfLine + 2];
                    lineSplit = line.Split('#');

                }
            }
            else if (lineSplit[4].StartsWith("3"))
            {
                string tmp = oid.Substring(0, (oid.Length - 2));
                oid = tmp;

                line = dd[numberOfLine + 1];
                lineSplit = line.Split('#');
                while (lineSplit[4].StartsWith("4"))
                {

                    nameOfColumns.Add(lineSplit[2]);
                    numberOfLine++;
                    line = dd[numberOfLine + 1];
                    lineSplit = line.Split('#');

                }

            }
            else if (lineSplit[4].StartsWith("4"))
            {
                string tmp;
                int i = 2;

                line = dd[numberOfLine];
                lineSplit = line.Split('#');

                nameOfColumns.Add(lineSplit[2]);


            }
            return nameOfColumns;

        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (monitor != null)
            {

                ts.Cancel();
                while (ts.IsCancellationRequested)
                {

                }

            }
            string OID = MonitorTextBox.Text;
            string option = OperationsComboBox.Text;
            string type = string.Empty; //syntax
            string name = string.Empty; //object name
            string value = string.Empty;



            monitor = Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    if (ct.IsCancellationRequested)
                    {
                        ts = new CancellationTokenSource();
                        ct = ts.Token;

                        break;
                    }
                    var result = snmp_agent.GetRequest(SnmpVersion.Ver2, OID, IP);


                    value = result.Pdu.VbList[0].Value.ToString();

                    if (value == "Null" || value == "NULL" || value == "null")
                    {

                        MessageBox.Show("No such name error(127.0.0.1)", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        _Application.richTextBox1.Invoke(new Action(delegate ()
                             {
                            _Application.richTextBox1.Text = "Oid: " + OID + " Value: " + value+ "  Time ["+DateTime.Now+"]";

                        }));


                    }
                    await Task.Delay(3000);
                }


            }, ct);
        }

        public void TrapReceivedSNMPAgentNotify()
        {
            
            runTrap = true;
            if (isNotBindedPort)
            {
                 socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 162);
                EndPoint ep = (EndPoint)ipep;
                socket.Bind(ep);

                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);
                isNotBindedPort = false;
            }
            int inlen = -1;
            while (runTrap)
            {
                DateTime time = DateTime.Now;
                byte[] indata = new byte[16 * 1024];

                IPEndPoint peer = new IPEndPoint(IPAddress.Any, 0);
                EndPoint inep = (EndPoint)peer;
                try
                {
                    inlen = socket.ReceiveFrom(indata, ref inep);
                    time = DateTime.Now;
                }
                catch (Exception ex)
                {
                    inlen = -1;
                }
                if (inlen > 0)
                {
                    int ver = SnmpPacket.GetProtocolVersion(indata, inlen);
                    if (ver == (int)SnmpVersion.Ver1)
                    {
                        SnmpV1TrapPacket pkt = new SnmpV1TrapPacket();
                        pkt.decode(indata, inlen);

                        foreach (Vb v in pkt.Pdu.VbList)
                        {
                           
                            addRowToAgentNotify(pkt.Pdu.AgentAddress.ToString(), v.Oid.ToString(), v.Value.ToString(),
                                 time, pkt.Pdu.Generic);
                        }
                    }
                    else
                    {
                        // Parse SNMP Version 2 TRAP packet 
                        SnmpV2Packet pkt = new SnmpV2Packet();
                        pkt.decode(indata, inlen);
                        if ((PduType)pkt.Pdu.Type != PduType.V2Trap)
                        {                            
                        }
                        else
                        {
                            
                            foreach (Vb v in pkt.Pdu.VbList)
                            {
                                addRowToAgentNotify("", v.Oid.ToString(), v.Value.ToString(),
                                 time, "");
                            }
                            
                        }
                    }
                }
            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startReciverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() => TrapReceivedSNMPAgentNotify());
            startReciverToolStripMenuItem.Enabled = false;
            stopReciverToolStripMenuItem.Enabled = true;
        }

        private void stopReciverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runTrap = false;
            stopReciverToolStripMenuItem.Enabled = false;
            startReciverToolStripMenuItem.Enabled = true;
        }

        public bool SendTrap(TrapAgent agent, String receiverIP, int port, String community, String oid,
           String senderIP, int generic, int specific, uint senderUpTime, VbCollection col)
        {
            try
            {
                agent.SendV1Trap(new IpAddress(receiverIP), port, community,
                    new Oid(oid), new IpAddress(senderIP),
                    generic, specific, senderUpTime, col);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static VbCollection CreateVbCol(String value, String name)
        {
            VbCollection col = new VbCollection();
            col.Add(new Oid(name), new OctetString(value));

            return col;
        }

        private void buttonTSSend_Click(object sender, EventArgs e)
        {
            bool isSent = SendTrap(trapAgent,
                            textBoxTSAddress.Text,
                            int.Parse(textBoxTSPort.Text),
                            textBoxTSCommunity.Text,
                            "",
                            "",
                            comboBoxTSGeneric.SelectedIndex,
                            0,
                            0,
                            CreateVbCol(textBoxTSValue.Text,
                                            textBoxTSName.Text
                                            )
                          );
            if (isSent)
                MessageBox.Show("Trap Sent");
            else MessageBox.Show("Error");
        }
    }
}


