﻿namespace OBD.NET.OBDData
{
    public class OxygenSensor4FuelAir : AbstractOBDData
    {
        #region Properties & Fields

        public double FuelAirEquivalenceRatio => (2.0 / 25536.0) * ((256 * A) + B);
        public double Voltage => (80 / 25536.0) * ((256 * C) + D);

        #endregion

        #region Constructors

        public OxygenSensor4FuelAir()
            : base(0x27, 4)
        { }

        #endregion
    }
}