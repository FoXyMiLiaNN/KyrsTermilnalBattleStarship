using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.HyperAccelerators;
using Kyrs_StarBattleshipTerminal.Sectors;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.ReactiveAccelerators;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Batterys;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.CapitansBridgeFabric;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Frame;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.FuelTanks;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.LivingCompartments;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.LocationSystems;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.MotorsFabric;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.ShieldGenerators.MainShieldGenerator;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.ShieldGenerators.ReserveShieldGenerator;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.StorageCompartments;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.DeffenceTurrets;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.Experimentals.Nuke;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.Experimentals.Railgun;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.AntiAirTurret;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.Canons;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.LaserTurrets;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.RocketTurets;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics;

namespace Kyrs_StarBattleshipTerminal
{
    internal class De__Serialisation
    {
        private List<object> _serialisation = new List<object>();
        private BinaryFormatter formatter = new BinaryFormatter();
        private string linkBat = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "Save.bat";
        public De__Serialisation(List<object> _serialisation)
        {
            this._serialisation = _serialisation;
        }
        public void Serialize()
        {
            using (FileStream fs = new FileStream(linkBat, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _serialisation);
            }
        }
        public void Deserialize()
        {
            using (FileStream fs = new FileStream(linkBat, FileMode.OpenOrCreate))
            {
                List<object> newobj = (List<object>)formatter.Deserialize(fs);
            }
        }
    }

    class Serlztn
    {
        //public MainConverter converter = new MainConverter();
        private De__Serialisation ds;
        private List<object> list = new List<object>();
        public Serlztn()
        {
            //Frame
            AllMainStarBattleShipInfo info = new AllMainStarBattleShipInfo(new Frame_Fabric());
            list.Add(info);
            //Accelerators
            info = new AllMainStarBattleShipInfo(new MainCoverter_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new LeftManevrators_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new RightManevrators_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new FrontManevrators_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new BackManevrators_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new PrimaryAccelerators_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new SecondaryAccelerators_Fabric());
            list.Add(info);
            //Batteries
            info = new AllMainStarBattleShipInfo(new Batteries_Fabric());
            list.Add(info);
            //CapitansBridge
            info = new AllMainStarBattleShipInfo(new CapitansBridge_Fabric());
            list.Add(info);
            //FuelTanks
            info = new AllMainStarBattleShipInfo(new IonGaseTanks_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new KerasinTanks_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new DarkMateryTanks_Fabric());
            list.Add(info);
            //LivingCompartments
            info = new AllMainStarBattleShipInfo(new Room1_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new Room2_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new Room3_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new Room4_Fabric());
            list.Add(info);
            //LocationSystems
            info = new AllMainStarBattleShipInfo(new LocationSystems_Fabric());
            list.Add(info);
            //MedicineCompartments
            info = new AllMainStarBattleShipInfo(new MedicineCompartments_Fabric());
            list.Add(info);
            //Motors
            info = new AllMainStarBattleShipInfo(new IonMotors_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new ReactiveMotors_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new HyperMotors_Fabric());
            list.Add(info);
            //Reactors
            info = new AllMainStarBattleShipInfo(new ReactiveMotors_Fabric());
            list.Add(info);
            //Shields
            info = new AllMainStarBattleShipInfo(new MainShieldGenerator_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new ReserveShieldGenerator_Fabric());
            list.Add(info);
            //StorageCompartments
            info = new AllMainStarBattleShipInfo(new LargeStorage_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new MiddleStorage_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new SmallStorage_Fabric());
            list.Add(info);
            //Weapons
            info = new AllMainStarBattleShipInfo(new MainDeffenceTurret_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new AntiAirTurret1_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new Canon1_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new LaserTurret1_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new RocketTurret1_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new Launcher1_Fabric());
            list.Add(info);
            info = new AllMainStarBattleShipInfo(new Railgun1_Factory());
            list.Add(info);

            ds = new De__Serialisation(list);
        }
        public void SerializeAll()
        {
            ds.Serialize();
        }
        public void DeserializeAll() 
        {
            ds.Deserialize();
        }
    }
}
