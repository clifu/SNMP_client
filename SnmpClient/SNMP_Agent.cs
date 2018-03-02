using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SnmpClient;
using SnmpSharpNet;

namespace SnmpClient
{
    /// <summary>
    /// Klasa z funkcjonalnością agenta SNMP
    /// </summary>
    public class SNMP_Agent
    {
        /// <summary>
        /// Klasa z narzędziami snmp
        /// </summary>
        public SimpleSnmp snmp;

        /// <summary>
        /// Cel pakietów UDP
        /// </summary>
        public UdpTarget target;

        /// <summary>
        /// Konstruktor, ustawia "localhost" i "public"
        /// </summary>
        public SNMP_Agent()
        {
            //Stworzenie nowego obiektu klasy z narzedziami do SNMP, dzialajacej na lokalnym hoscie i w publicznej sieci 
            snmp = new SimpleSnmp("localhost", "public");

            //Stworzenie nowego celu UDP
            target = new UdpTarget(snmp.PeerIP, 161, 2000, 1);
        }

        /// <summary>
        /// Konstruktor, ustawiający peerName i community. W przypadku błędu ustawi peerName na"localhost" i 
        /// community na "public"
        /// </summary>
        /// <param name="peerName"></param>
        /// <param name="community"></param>
        public SNMP_Agent(string peerName, string community)
        {
            try
            {
                snmp = new SimpleSnmp(peerName, community);

                //Stworzenie nowego celu UDP
                target = new UdpTarget(snmp.PeerIP, 161, 2000, 1);
            }
            catch (Exception E)
            {
                Console.WriteLine("SNMP_Agent's constructor: " + E.Message);
                snmp = new SimpleSnmp("localhost", "public");
            }

        }

        /// <summary>
        /// Funkcja realizująca polecenie Get agenta SNMP.
        /// SnmpVersion: SnmpVersion.Ver1 lub SnmpVersion.Ver2 lub SnmpVersion.Ver3. Zalecana Ver2.
        /// oidList: Lista identyfikatorów OID, których obiekty ma znalezc funkcja.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="oidList"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public SnmpPacket GetRequest(SnmpVersion version, string[] oidList, IPAddress agent)
        {
            // Pdu class used for all requests
            Pdu pdu = new Pdu(PduType.Get);

            foreach (var oid in oidList)
            {
                pdu.VbList.Add(oid);
            }

            // SNMP community name
            OctetString community = new OctetString(snmp.Community);

            // Define agent parameters class
            AgentParameters param = new AgentParameters(community);

            // Set SNMP version to 1 (or 2)
            param.Version = version;

            // Make SNMP request
            SnmpPacket result = target.Request(pdu, param);

            return result;
        }


        /// <summary>
        /// Funkcja realizująca polecenie Get agenta SNMP.
        /// SnmpVersion: SnmpVersion.Ver1 lub SnmpVersion.Ver2 lub SnmpVersion.Ver3. Zalecana Ver2.
        /// oid: Identyfikator OID, którego obiekt ma znalezc funkcja.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="oid"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public SnmpPacket GetRequest(SnmpVersion version, string oid, IPAddress agent)
        {
            return this.GetRequest(version, new string[] { oid }, agent);
        }

        /// <summary>
        /// Funkcja realizująca polecenie GetNext agenta SNMP.
        /// SnmpVersion: SnmpVersion.Ver1 lub SnmpVersion.Ver2 lub SnmpVersion.Ver3. Zalecana Ver2.
        /// oidList: Lista identyfikatorów OID, których obiekty ma znalezc funkcja.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="oid"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public SnmpPacket GetNextRequest(SnmpVersion version, string[] oidList, IPAddress agent)
        {
            // Pdu class used for all requests
            Pdu pdu = new Pdu(PduType.GetNext);

            foreach (var oid in oidList)
            {
                pdu.VbList.Add(oid);
            }

            // SNMP community name
            OctetString community = new OctetString(snmp.Community);

            // Define agent parameters class
            AgentParameters param = new AgentParameters(community);

            // Set SNMP version to 1 (or 2)
            param.Version = version;

            // Make SNMP request
            SnmpPacket result = target.Request(pdu, param);
            

            return result;
        }

        /// <summary>
        /// Funkcja realizująca polecenie GetNext agenta SNMP.
        /// SnmpVersion: SnmpVersion.Ver1 lub SnmpVersion.Ver2 lub SnmpVersion.Ver3. Zalecana Ver2.
        /// oid: Identyfikator OID, którego obiekt ma znalezc funkcja.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="oid"></param>
        /// <param name="agent"></param>
        /// <returns></returns>
        public SnmpPacket GetNextRequest(SnmpVersion version, string oid, IPAddress agent)
        {
            return this.GetNextRequest(version, new string[] { oid }, agent);
        }

        /// <summary>
        /// Funkcja zwracająca , zaczynając od obiektu o oid podanym w argumencie.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="startOid"></param>
        /// <returns></returns>
        public Dictionary<String, Dictionary<uint, AsnType>> GetTableRequest(SnmpVersion version, string _startOid)
        {
            Dictionary<String, Dictionary<uint, AsnType>> resultDictionary = new Dictionary<String, Dictionary<uint, AsnType>>();

            //To jest OID tabeli na wejściu funkcji
            Oid startOid = new Oid(_startOid);

            /*
            // Not every row has a value for every column so keep track of all columns available in the table
            List<uint> tableColumns = new List<uint>();

            //Każda tabela OID ma na końcu .1 dla wpisu OID, trzeba go dodać do tabeli
            startOid.Add(1);

            //Przygotowanie PDU do zapytania
            Pdu pdu = new Pdu(PduType.GetNext);

            //Dodanie startOid do VarBindList PDU
            pdu.VbList.Add(startOid);
            */

            Oid currentOid = (Oid)startOid.Clone();
            
            AgentParameters param = new AgentParameters(
                version, new OctetString(snmp.Community));

            //Dopoki nie osiagniemy konca tabeli
            while (startOid.IsRootOf(currentOid))
            {
                SnmpPacket result = null;

                try
                {
                    result = this.GetNextRequest(SnmpVersion.Ver2, currentOid.ToString(), this.snmp.PeerIP);
                }
                catch (Exception e)
                {
                    Console.WriteLine("GetTableRequest(): request failed. " + e.Message);
                    return null;
                }

                if (result.Pdu.ErrorStatus != 0)
                {
                    Console.WriteLine("SNMP Agent returned error: " + result.Pdu.ErrorStatus +
                                      " for request with Vb of index: " + result.Pdu.ErrorIndex);
                    return null;
                }

                foreach (Vb v in result.Pdu.VbList)
                {
                    currentOid = (Oid)v.Oid.Clone();

                    //upewniamy sie ze jestesmy w tabeli
                    if (startOid.IsRootOf(v.Oid))
                    {
                        //Otrzymanie ID childa z OID
                        uint[] childOids = Oid.GetChildIdentifiers(startOid, v.Oid);

                        // Get the value instance and converted it to a dotted decimal
                        //  string to use as key in result dictionary
                        uint[] instance = new uint[childOids.Length - 1];

                        Array.Copy(childOids, 1, instance, 0, childOids.Length - 1);

                        String strInst = InstanceToString(instance);
                        // Column id is the first value past <table oid>.entry in the response OID

                        uint column = childOids[0];
                        
                        if (resultDictionary.ContainsKey(strInst))
                        {
                            resultDictionary[strInst][column] = (AsnType)v.Value.Clone();
                        }
                        else
                        {
                            resultDictionary[strInst] = new Dictionary<uint, AsnType>();
                            resultDictionary[strInst][column] = (AsnType)v.Value.Clone();
                        } 
                    }
                    else
                    {
                        // We've reached the end of the table. No point continuing the loop
                        break;
                    }
                }
            }
            return resultDictionary;
        }

        public static string InstanceToString(uint[] instance)
        {
            StringBuilder str = new StringBuilder();
            foreach (uint v in instance)
            {
                if (str.Length == 0)
                    str.Append(v);
                else
                    str.AppendFormat(".{0}", v);
            }
            return str.ToString();
        }
    }
}

