using System.Threading;

namespace kerslager_nabijeni
{
    public class ChargingStation
    {
        public enum StationState
        {
            Start,
            Arrived,
            Inside,
            Charging,
            Finished,
            Leaving
        }

        public enum LightState
        {
            Green, // nabito
            Orange, // nabíjení
            Red // prázdno
        }

        private Thread _thread = new Thread(ThreadProcedure);

        public ChargingStation(int initialChargeLevel, int maxChargeLevel)
        {
            State = StationState.Start;
            _chargeLevel = initialChargeLevel;
            _maxChargeLevel = maxChargeLevel;
            _thread.Start(this);
        }
        public StationState State { get; set; }


        private LightState _entryLightState = LightState.Red;
        public LightState StatusLightState
        {
            get
            {
                return _entryLightState;
            }
            private set
            {
                bool flag = value != _entryLightState;
                _entryLightState = value;
                if (flag)
                {
                    this.OnLightStateChange?.Invoke(this, _entryLightState);
                }
            }
        }

        private int _chargeLevel;
        private int _maxChargeLevel;
        public int ChargeLevel
        {
            get
            {
                return _chargeLevel;
            }
            private set
            {
                bool flag = value != _chargeLevel;
                _chargeLevel = value;
                if (flag)
                {
                    this.OnChargeLevelChange?.Invoke(this, _chargeLevel);
                }
            }
        }

        public int MaxChargeLevel
        {
            get
            {
                return _maxChargeLevel;
            }
            private set
            {
                bool flag = value != _maxChargeLevel;
                _maxChargeLevel = value;
                if (flag)
                {
                    this.OnMaxChargeLevelChange?.Invoke(this, _chargeLevel);
                }
            }
        }

        public delegate void ChangedLightStateHandler(object sender, LightState LightState);
        public delegate void ChangedChargeLevelHandler(object sender, int chargeLevel);
        public delegate void ChangedMaxChargeLevelHandler(object sender, int maxChargeLevel);
        public event ChangedLightStateHandler OnLightStateChange;
        public event ChangedChargeLevelHandler OnChargeLevelChange;
        public event ChangedMaxChargeLevelHandler OnMaxChargeLevelChange;

        private static void ThreadProcedure(object obj)
        {
            ChargingStation chargingStation = (ChargingStation)obj;
            while (true)
            {
                switch (chargingStation.State)
                {
                    case StationState.Arrived:
                        chargingStation.StatusLightState = LightState.Red;
                        break;
                    case StationState.Inside:
                        chargingStation.State = StationState.Charging;
                        break;
                    case StationState.Charging:
                        chargingStation.StatusLightState = LightState.Orange;
                        if (chargingStation.ChargeLevel < chargingStation.MaxChargeLevel)
                        {
                            chargingStation.StatusLightState = LightState.Green;
                            chargingStation.ChargeLevel += 2;
                            Thread.Sleep(100);
                        }
                        else
                        {
                            chargingStation.State = StationState.Finished;
                        }

                        break;
                    case StationState.Finished:
                        chargingStation.StatusLightState = LightState.Green;
                        break;
                    case StationState.Leaving:
                        chargingStation.StatusLightState = LightState.Red;
                        chargingStation.ChargeLevel = 0;
                        break;
                }
            }
        }


        public void Dispose()
        {
            try
            {
                _thread.Interrupt();
                _thread.Join();
            }
            catch (Exception)
            {
            }
        }

    }
}