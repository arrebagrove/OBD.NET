﻿using OBD.NET.DataTypes;

namespace OBD.NET.OBDData
{
    public class ControlModuleVoltage : AbstractOBDData
    {
        #region Properties & Fields

        public Volt Voltage => new Volt(((256 * A) + B) / 1000.0, 0, 65.535);

        #endregion

        #region Constructors

        public ControlModuleVoltage()
            : base(0x42, 2)
        { }

        #endregion
    }
}
