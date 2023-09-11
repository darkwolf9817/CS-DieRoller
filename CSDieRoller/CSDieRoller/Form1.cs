using System.Diagnostics.Eventing.Reader;

namespace CSDieRoller
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int numDice = int.Parse(nbxDieCount.Value.ToString());
            int dieRoll = Roll(numDice, cbxDieType.SelectedItem.ToString());

            outBox.Items.Add($"You rolled a {dieRoll}!!!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outBox.Items.Clear();
            rdo3d6.Checked = false;
            rdo4d6.Checked = false;
            nbxDieCount.Value = 0;
        }

        private void btnAbility_Click(object sender, EventArgs e)
        {
            int result = AbilityRoll(rdo3d6.Checked, rdo4d6.Checked);
            string method;
            if (rdo3d6.Checked)
            {
                method = "3d6";
            }
            else
            {
                method = "4d6";
            }
            outBox.Items.Add($"Rolling ability using the {method} method: {result}");
        }

        private int Roll(int numDice, string dieType)
        {
            int numSides = GetSides(dieType);
            int totalRoll = 0;
            int dieRoll;
            Random die = new Random();

            // Uses a for loop to generate a random number for each die, and sum the values.
            for (int i = 1; i <= numDice; i++)
            {
                dieRoll = die.Next(numSides) + 1;
                if (dieRoll > numSides)
                {
                    dieRoll = numSides;
                }
                totalRoll += dieRoll;
            }
            return totalRoll;
        }

        private int GetSides(string dieType)
        {
            int numSides = 0;

            // A switch statement to retrieve the number of sides of the selected die type
            switch (dieType)
            {
                case "D20":
                    numSides = 20;
                    break;
                case "D12":
                    numSides = 12;
                    break;
                case "D10":
                    numSides = 10;
                    break;
                case "D8":
                    numSides = 8;
                    break;
                case "D6":
                    numSides = 6;
                    break;
                case "D4":
                    numSides = 4;
                    break;
                case "D100":
                    numSides = 100;
                    break;
                default:
                    MessageBox.Show("Please select a valid die type from the die type box.");
                    break;
            }
            return numSides;
        }

        private int AbilityRoll(bool m1, bool m2)
        {
            int numDice, dieRoll;
            int totalRoll = 0;
            List<int> dieList = new List<int>();
            // Will use list to handle 4d6 drop lowest.

            if (m1)
            {
                totalRoll = Roll(3, "D6");
            }
            else if (m2)
            {
                numDice = 4;
                for (int i = 1; i <= numDice; i++)
                {
                    // Will roll the die and then add it to the list. 
                    dieRoll = Roll(1, "D6");
                    dieList.Add(dieRoll);
                }

                // Will sort the list, then remove the lowest value. 
                dieList.Sort();
                dieList.Remove(0);
                totalRoll = dieList.Sum();
            }
            else
            {
                MessageBox.Show("Please choose one of the rolling methods, either 3d6 or 4d6.");
            }
            return totalRoll;
        }
    }
}