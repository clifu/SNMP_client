using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnmpClient;
using SnmpSharpNet;

namespace SnmpClient
{
    /// <summary>
    /// Klasa do testowania funkcjonalności klasy AgentSNMP
    /// </summary>
    [TestClass]
    public class SNMP_Agent_Tester
    {
        [TestMethod]
        public void setUp()
        {
            SNMP_Agent agent = new SNMP_Agent();
            Assert.AreEqual(agent.snmp.Community, "public");
            Assert.AreEqual(agent.snmp.PeerName, "localhost");
            Assert.IsTrue(agent.snmp.Valid);
        }

        [TestMethod]
        public void TestGetRequest1()
        {
            SNMP_Agent agent = new SNMP_Agent();
            string oid = "1.3.6.1.2.1.2.2.1";

            var result = agent.GetRequest(SnmpVersion.Ver2, oid);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.ContainsValue(new Oid(oid)));
        }
    }
}