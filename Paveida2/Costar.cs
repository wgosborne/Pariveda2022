using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paveida2
{
    public partial class Costar : Form
    {
        public Costar()
        {
            InitializeComponent();
        }

        private void Costar_Load(object sender, EventArgs e)
        {

        }

        private string zodiac_sign(int day, string month)
        {
            string astro_sign = "";
            // checks month and date within the
            // valid range of a specified zodiac
            if (month.ToLower() == "december")
            {

                if (day < 22)
                    astro_sign = "Sagittarius";
                else
                    astro_sign = "Capricorn";
            }

            else if (month.ToLower() == "january")
            {
                if (day < 20)
                    astro_sign = "Capricorn";
                else
                    astro_sign = "Aquarius";
            }

            else if (month.ToLower() == "february")
            {
                if (day < 19)
                    astro_sign = "Aquarius";
                else
                    astro_sign = "Pisces";
            }

            else if (month.ToLower() == "march")
            {
                if (day < 21)
                    astro_sign = "Pisces";
                else
                    astro_sign = "Aries";
            }
            else if (month.ToLower() == "april")
            {
                if (day < 20)
                    astro_sign = "Aries";
                else
                    astro_sign = "Taurus";
            }

            else if (month.ToLower() == "may")
            {
                if (day < 21)
                    astro_sign = "Taurus";
                else
                    astro_sign = "Gemini";
            }

            else if (month.ToLower() == "june")
            {
                if (day < 21)
                    astro_sign = "Gemini";
                else
                    astro_sign = "Cancer";
            }

            else if (month.ToLower() == "july")
            {
                if (day < 23)
                    astro_sign = "Cancer";
                else
                    astro_sign = "Leo";
            }

            else if (month.ToLower() == "august")
            {
                if (day < 23)
                    astro_sign = "Leo";
                else
                    astro_sign = "Virgo";
            }

            else if (month.ToLower() == "september")
            {
                if (day < 23)
                    astro_sign = "Virgo";
                else
                    astro_sign = "Libra";
            }

            else if (month.ToLower() == "october")
            {
                if (day < 23)
                    astro_sign = "Libra";
                astro_sign = "Scorpio";
            }

            else if (month.ToLower() == "november")
            {
                if (day < 22)
                    astro_sign = "Scorpio";
                else
                    astro_sign = "Sagittarius";
            }

            if (astro_sign.ToLower() == "aries")
            {
                astro_sign += ": The first sign of the zodiac, Aries loves to be number one. Naturally, this dynamic fire sign is no stranger to competition. Bold and ambitious, Aries dives headfirst into even the most challenging situations—and they'll make sure they always come out on top!";
            }
            else if (astro_sign.ToLower() == "taurus")
            {
                astro_sign += ": What sign is more likely to take a six-hour bath, followed by a luxurious Swedish massage and decadent dessert spread? Why Taurus, of course! Taurus is an earth sign represented by the bull. Like their celestial spirit animal, Taureans enjoy relaxing in serene, bucolic environments surrounded by soft sounds, soothing aromas, and succulent flavors. ";
            }
            else if (astro_sign.ToLower() == "gemini")
            {
                astro_sign += ": Have you ever been so busy that you wished you could clone yourself just to get everything done? That's the Gemini experience in a nutshell. Spontaneous, playful, and adorably erratic, Gemini is driven by its insatiable curiosity. Appropriately symbolized by the celestial twins, this air sign was interested in so many pursuits that it had to double itself. You know, NBD!";

            }
            else if (astro_sign.ToLower() == "cancer")
            {
                astro_sign += ": Represented by the crab, Cancer seamlessly weaves between the sea and shore representing Cancer’s ability to exist in both emotional and material realms. Cancers are highly intuitive and their psychic abilities manifest in tangible spaces. But—just like the hard-shelled crustaceans—this water sign is willing to do whatever it takes to protect itself emotionally. In order to get to know this sign, you're going to need to establish trust!";

            }
            else if (astro_sign.ToLower() == "leo")
            {
                astro_sign += "Roll out the red carpet because Leo has arrived. Passionate, loyal, and infamously dramatic, Leo is represented by the lion and these spirited fire signs are the kings and queens of the celestial jungle. They're delighted to embrace their royal status: Vivacious, theatrical, and fiery, Leos love to bask in the spotlight and celebrate… well, themselves.";

            }
            else if (astro_sign.ToLower() == "virgo")
            {
                astro_sign += "You know the expression, 'if you want something done, give it to a busy person?' Well, that definitely is the Virgo anthem. Virgos are logical, practical, and systematic in their approach to life. Virgo is an earth sign historically represented by the goddess of wheat and agriculture, an association that speaks to Virgo's deep-rooted presence in the material world. This earth sign is a perfectionist at heart and isn’t afraid to improve skills through diligent and consistent practice.";

            }
            else if (astro_sign.ToLower() == "libra")
            {
                astro_sign += "Balance, harmony, and justice define Libra energy. As a cardinal air sign, Libra is represented by the scales (interestingly, the only inanimate object of the zodiac), an association that reflects Libra's fixation on establishing equilibrium. Libra is obsessed with symmetry and strives to create equilibrium in all areas of life — especially when it comes to matters of the heart.";

            }
            else if (astro_sign.ToLower() == "scorpio")
            {
                astro_sign += "Elusive and mysterious, Scorpio is one of the most misunderstood signs of the zodiac. Scorpio is a water sign that uses emotional energy as fuel, cultivating powerful wisdom through both the physical and unseen realms. In fact, Scorpio derives its extraordinary courage from its psychic abilities, which is what makes this sign one of the most complicated, dynamic signs of the zodiac.";

            }
            else if (astro_sign.ToLower() == "sagittarius")
            {
                astro_sign += "Oh, the places Sagittarius goes! But… actually. This fire sign knows no bounds. Represented by the archer, Sagittarians are always on a quest for knowledge. The last fire sign of the zodiac, Sagittarius launches its many pursuits like blazing arrows, chasing after geographical, intellectual, and spiritual adventures.";

            }
            else if (astro_sign.ToLower() == "capricorn")
            {
                astro_sign += "What is the most valuable resource? For Capricorn, the answer is clear: Time. Capricorn is climbing the mountain straight to the top and knows that patience, perseverance, and dedication is the only way to scale. The last earth sign of the zodiac, Capricorn, is represented by the sea-goat, a mythological creature with the body of a goat and the tail of a fish. Accordingly, Capricorns are skilled at navigating both the material and emotional realms.";

            }
            else if (astro_sign.ToLower() == "aquarius")
            {
                astro_sign += "Despite the 'aqua' in its name, Aquarius is actually the last air sign of the zodiac. Innovative, progressive, and shamelessly revolutionary, Aquarius is represented by the water bearer, the mystical healer who bestows water, or life, upon the land. Accordingly, Aquarius is the most humanitarian astrological sign. At the end of the day, Aquarius is dedicated to making the world a better place.";

            }
            else if (astro_sign.ToLower() == "pisces")
            {
                astro_sign += "If you looked up the word 'psychic' in the dictionary, there would definitely be a picture of Pisces next to it. Pisces is the most intuitive, sensitive, and empathetic sign of the entire zodiac — and that’s because it’s the last of the last. As the final sign, Pisces has absorbed every lesson — the joys and the pain, the hopes and the fears — learned by all of the other signs. It's symbolized by two fish swimming in opposite directions, representing the constant division of Pisces' attention between fantasy and reality.";

            }
            astro_sign += "\r\n\r\nZodic Info Credits: https://www.allure.com/story/zodiac-sign-personality-traits-dates#:~:text=Generally%20speaking%2C%20fire%20signs%20are,signs%20are%20intuitive%20and%20emotional.";

            return astro_sign;
        }

        private void zodiacPanel_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void go_Click(object sender, EventArgs e)
        {
            int day = int.Parse(birthDay.Text);
            string month = birthMonth.Text;
            string astro_sign = "";

            astro_sign = zodiac_sign(day, month);
            zodiacInfo.Text = astro_sign;
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the Zodiac Window?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
