using kerslager_nabijeni;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VAPW
{
    public partial class Form1 : Form
    {

        private ChargingStation station;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            station = new ChargingStation(initialChargeLevel: 0, maxChargeLevel: 100);
            var mode = new Form2();
            var result = mode.ShowDialog();

            if (result == DialogResult.OK && mode.UseTimer)
            {
                //UpdateInfoLabel.Text = "Ticker";
                Ticker.Interval = 100;
                Ticker.Tick += Timer_Tick;
                Ticker.Enabled = true;
            }
            else
            {
                //UpdateInfoLabel.Text = "Event";
                station.OnLightStateChange += Station_OnLightStateChange;
                station.OnChargeLevelChange += Station_OnChargeLevelChange;
            }

            station.State = ChargingStation.StationState.Start;

        }

        private void Station_OnLightStateChange(object sender, ChargingStation.LightState e)
        {
            VykreslitStav();
        }

        private void Station_OnChargeLevelChange(object sender, int e)
        {
            VykreslitStav();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            VykreslitStav();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (station.State)
            {
                case ChargingStation.StationState.Start:
                    station.State = ChargingStation.StationState.Arrived;
                    break;
                case ChargingStation.StationState.Arrived:
                    station.State = ChargingStation.StationState.Inside;
                    break;
                case ChargingStation.StationState.Charging:
                    station.State = ChargingStation.StationState.Finished;
                    break;
                case ChargingStation.StationState.Finished:
                    station.State = ChargingStation.StationState.Leaving;
                    break;
                case ChargingStation.StationState.Leaving:
                    StartButton.Text = "Zaèít";
                    station.State = ChargingStation.StationState.Start;
                    break;
                default:
                    break;
            }
            VykreslitStav();

        }
        private void VykreslitStav()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { UpdateUI(); });
            }
            else
            {
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            // Update UI elements based on the station's state and properties
            textBox1.Text = station.State.ToString();
            progressBar1.Value = station.ChargeLevel;


            switch (station.State)
            {
                case ChargingStation.StationState.Start:
                    StartButton.Text = "Start";
                    panel1.BackColor = Color.Red;
                    pictureBox1.Location = new Point(800, 500);
                    break;
                case ChargingStation.StationState.Arrived:
                    StartButton.Text = "Zapoj";
                    pictureBox1.Location = new Point(24, 176);
                    break;
                case ChargingStation.StationState.Inside:
                    pictureBox1.Location = new Point(148, 182);
                    break;
                case ChargingStation.StationState.Charging:
                    StartButton.Text = "Odeber";
                    pictureBox1.Location = new Point(148, 182);
                    panel1.BackColor = Color.Orange;
                    if (station.ChargeLevel <= 100)
                    {
                        StartButton.Enabled = false;
                    }
                    break;
                case ChargingStation.StationState.Finished:
                    StartButton.Enabled = true;
                    panel1.BackColor = Color.Green;
                    break;
                case ChargingStation.StationState.Leaving:
                    panel1.BackColor = Color.Red;
                    pictureBox1.Location = new Point(24, 176);
                    break;
                default:
                    panel1.BackColor = SystemColors.Control;
                    break;
            }

            // Update other UI elements as needed
        }
    }
}
