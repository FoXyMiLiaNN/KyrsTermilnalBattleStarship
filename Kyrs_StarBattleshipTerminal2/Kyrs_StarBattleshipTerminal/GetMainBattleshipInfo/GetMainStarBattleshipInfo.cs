using Kyrs_StarBattleshipTerminal.Sectors.Fabrics;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.HyperAccelerators;
using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.ReactiveAccelerators;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors
{
    internal class StarBattleshipFrame
    {
        private string result { get; set; }
        private StarBattleshipFrame()
        {
            //Frame
            AllMainStarBattleShipInfo info = new AllMainStarBattleShipInfo(new Frame_Fabric());
            result = $"{info.GetMainInfo()}";
            //Accelerators
            info = new AllMainStarBattleShipInfo(new MainCoverter_Fabric());
            result += $"{info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new LeftManevrators_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new RightManevrators_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new FrontManevrators_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new BackManevrators_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new PrimaryAccelerators_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new SecondaryAccelerators_Fabric());
            result += $", {info.GetMainInfo()}";
            //Batteries
            info = new AllMainStarBattleShipInfo(new Batteries_Fabric());
            result += $", {info.GetMainInfo()}";
            //CapitansBridge
            info = new AllMainStarBattleShipInfo(new CapitansBridge_Fabric());
            result += $", {info.GetMainInfo()}";
            //FuelTanks
            info = new AllMainStarBattleShipInfo(new IonGaseTanks_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new KerasinTanks_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new DarkMateryTanks_Fabric());
            result += $", {info.GetMainInfo()}";
            //LivingCompartments
            info = new AllMainStarBattleShipInfo(new Room1_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new Room2_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new Room3_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new Room4_Fabric());
            result += $", {info.GetMainInfo()}";
            //LocationSystems
            info = new AllMainStarBattleShipInfo(new LocationSystems_Fabric());
            result += $", {info.GetMainInfo()}";
            //MedicineCompartments
            info = new AllMainStarBattleShipInfo(new MedicineCompartments_Fabric());
            result += $", {info.GetMainInfo()}";
            //Motors
            info = new AllMainStarBattleShipInfo(new IonMotors_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new ReactiveMotors_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new HyperMotors_Fabric());
            result += $", {info.GetMainInfo()}";
            //Reactors
            info = new AllMainStarBattleShipInfo(new ReactiveMotors_Fabric());
            result += $", {info.GetMainInfo()}";
            //Shields
            info = new AllMainStarBattleShipInfo(new MainShieldGenerator_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new ReserveShieldGenerator_Fabric());
            result += $", {info.GetMainInfo()}";
            //StorageCompartments
            info = new AllMainStarBattleShipInfo(new LargeStorage_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new MiddleStorage_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new SmallStorage_Fabric());
            result += $", {info.GetMainInfo()}";
            //Weapons
            info = new AllMainStarBattleShipInfo(new MainDeffenceTurret_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new AntiAirTurret1_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new Canon1_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new LaserTurret1_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new RocketTurret1_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new Launcher1_Fabric());
            result += $", {info.GetMainInfo()}";
            info = new AllMainStarBattleShipInfo(new Railgun1_Factory());
            result += $", {info.GetMainInfo()}";
        }
    }

    class AllMainStarBattleShipInfo
    {
        private TerminalInfoGetter infoGetter;
        public AllMainStarBattleShipInfo(Compartments_Factory factory)
        {
            infoGetter = factory.CreateInfoGetter();
        }

        public string GetInfo()
        {
            return infoGetter.GetInfo();
        }
        public string GetMainInfo()
        {
            return infoGetter.GetMainInfo();
        }
    }
}
