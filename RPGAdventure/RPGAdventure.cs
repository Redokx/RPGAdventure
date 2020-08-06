using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace RPGAdventure
{
    public partial class RPGAdventure : Form
    {
        private Player _player;

        public RPGAdventure()
        {
            InitializeComponent();




            //constructor with values
            _player = new Player(10, 10, 20, 0, 1);

           
            //transfer data to label
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            //test2
            int a = 1;
        }

        
    }
}
