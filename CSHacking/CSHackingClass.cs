using Memory;

namespace CSHacking
{
    /// <summary>
    /// Class for handling reading and writing memory to the Cyber Shadow process.
    /// </summary>
    public class CSHackingClass
    {
        Mem m = new Mem();

        const string hpAdr = "CyberShadow.exe+333EB60";
        const string spAdr = "CyberShadow.exe+333EB98";
        const string moneyAdr = "CyberShadow.exe+333EB78";
        const string subWepNameAdr = "CyberShadow.exe+333EF70";
        const string subWepIDAdr = "CyberShadow.exe+333EF80";
        const string xPOS = "CyberShadow.exe+32D84CC,0x8";
        const string yPOS = "CyberShadow.exe+32D84CC,0x10";

        #region Methods

        /// <summary>
        /// Checks if CyberShadow.exe is currently running.
        /// </summary>
        public bool CheckIfProcOpen()
        {
            bool procOpen = m.OpenProcess("CyberShadow");
            return procOpen;
        }

        #region Read Value Methods

        /// <summary>
        /// Read value of current HP in memory and return it as a double.
        /// </summary>
        public double ReadHPValue()
        {
            double hpValue = m.ReadDouble(hpAdr);
            return hpValue;
        }

        /// <summary>
        /// Read value of current SP in memory and return it as a double.
        /// </summary>
        public double ReadSPValue()
        {
            double spValue = m.ReadDouble(spAdr);
            return spValue;
        }

        /// <summary>
        /// Read value of current Money in memory and return it as a double.
        /// </summary>
        public double ReadMoneyValue()
        {
            double moneyValue = m.ReadDouble(moneyAdr);
            return moneyValue;
        }

        /// <summary>
        /// Read value of current Sub Wep Name in memory and return it as a string.
        /// </summary>
        public string ReadSubWepName()
        {
            string subWepName = m.ReadString(subWepNameAdr);
            return subWepName;
        }

        /// <summary>
        /// Read value of current Sub Wep ID in memory.
        /// </summary>
        /// <returns>integer</returns>
        public int ReadSubWepID()
        {
            int subWepID = m.ReadInt(subWepIDAdr);
            return subWepID;
        }

        /// <summary>
        /// Read value of current Player X Position in memory.
        /// </summary>
        /// <returns>double</returns>
        public double ReadXPOS()
        {
            double _xPOS = m.ReadDouble(xPOS);
            return _xPOS;
        }

        /// <summary>
        /// Read value of current Player Y Position in memory.
        /// </summary>
        /// <returns>double</returns>
        public double ReadYPOS()
        {
            double _yPOS = m.ReadDouble(yPOS);
            return _yPOS;
        }

        public double[] ReadPlayerPOS()
        {
            double[] xyArray = new double[2];
            xyArray[0] = ReadXPOS();
            xyArray[1] = ReadYPOS();

            return xyArray;
        }

        #endregion

        #region Write Value Methods

        public void WriteHP(string valueToWrite)
        {
            m.WriteMemory(hpAdr, "double", valueToWrite);
        }

        public void WriteSP(string valueToWrite)
        {
            m.WriteMemory(spAdr, "double", valueToWrite);
        }

        public void WriteMoney(string valueToWrite)
        {
            m.WriteMemory(moneyAdr, "double", valueToWrite);
        }
        
        public void WriteXPOS(string bytesToWrite)
        {
            m.WriteMemory(xPOS, "double", bytesToWrite);
        }

        public void WriteYPOS(string bytesToWrite)
        {
            m.WriteMemory(yPOS, "double", bytesToWrite);
        }

        public void WritePlayerPOS(string xPos, string yPos)
        {
            WriteXPOS(xPos);
            WriteYPOS(yPos);
        }

        #region Give Sub Weps Methods

        public void GiveSPDispenser()
        {
            m.WriteMemory(subWepNameAdr, "string", "sp_dispenser");
            m.WriteMemory(subWepIDAdr, "int", "12");
        }

        public void GiveSwagBlade()
        {
            m.WriteMemory(subWepNameAdr, "string", "swag_blade");
            m.WriteMemory(subWepIDAdr, "int", "10");
        }

        public void GiveBlaster()
        {
            m.WriteMemory(subWepNameAdr, "string", "blaster");
            m.WriteMemory(subWepIDAdr, "int", "7");
        }

        public void GiveBladeExtend()
        {
            m.WriteMemory(subWepNameAdr, "string", "blade_extend");
            m.WriteMemory(subWepIDAdr, "int", "12");
        }

        public void GiveSalvager()
        {
            m.WriteMemory(subWepNameAdr, "string", "salvager");
            m.WriteMemory(subWepIDAdr, "int", "8");
        }

        public void GiveNingun()
        {
            m.WriteMemory(subWepNameAdr, "string", "ningun");
            m.WriteMemory(subWepIDAdr, "int", "6");
        }

        public void GiveOrbiter()
        {
            m.WriteMemory(subWepNameAdr, "string", "orbiter");
            m.WriteMemory(subWepIDAdr, "int", "7");
        }

        #endregion

        #endregion

        #endregion
    }
}