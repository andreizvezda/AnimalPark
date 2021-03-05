/// MainForm.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalPark
{
    public partial class MainForm : Form
    {
        private AnimalManager manager = new AnimalManager();
        private FoodSchedule foodSchedule = new FoodSchedule();
        public MainForm()
        {
            InitializeComponent();

            //My initializations
            InitializeGUI();
            UpdateGUI();
        }
        private void InitializeGUI()
        {

            checkBoxAnimals.Checked = false;
            listBoxGender.Items.AddRange(Enum.GetNames(typeof(GenderType)));
            listBoxGender.SelectedIndex = 0;

            foreach (var category in Enum.GetValues(typeof(CategoryType)))
            {
                listBoxCategory.Items.Add(category);
            }

            listBoxCategory.SelectedIndex = 0;

        }

        /// <summary>
        /// Everytime the model changes, update the data on GUI
        /// </summary>
        private void UpdateGUI()
        {
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxTeeth.Text = string.Empty;
            textBoxTail.Text = string.Empty;
            //label3.Text = string.Format("{0,-10}{1,-20}{2,10}{3,10}", "ID", "NAME", "AGE", "GENDER");
            listView1.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("NAME", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("AGE", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("GENDER", 120, HorizontalAlignment.Left);
        }

        private void checkBoxAnimals_CheckedChanged(object sender, EventArgs e)
        {
            //method to list all animals and disable category list
            if (checkBoxAnimals.Checked == true)
            {
                listBoxAnimal.Items.Clear();

                foreach (var category in Enum.GetValues(typeof(BirdsSpecies)))
                {
                    listBoxAnimal.Items.Add(category);
                }

                foreach (var category in Enum.GetValues(typeof(ReptileSpecies)))
                {
                    listBoxAnimal.Items.Add(category);
                }

                foreach (var category in Enum.GetValues(typeof(MammalSpecies)))
                {
                    listBoxAnimal.Items.Add(category);
                }

                listBoxCategory.Enabled = false;
            }
            else
            {
                listBoxCategory.Enabled = true;
                listBoxAnimal.Items.Clear();
                if (listBoxCategory.SelectedIndex == 0)
                {
                    foreach (var category in Enum.GetValues(typeof(BirdsSpecies)))
                    {
                        listBoxAnimal.Items.Add(category);
                    }
                    listBoxAnimal.Update();

                }
                else if (listBoxCategory.SelectedIndex == 1)
                {
                    foreach (var category in Enum.GetValues(typeof(ReptileSpecies)))
                    {
                        listBoxAnimal.Items.Add(category);

                    }
                    listBoxAnimal.Update();

                }
                else if (listBoxCategory.SelectedIndex == 2)
                {
                    foreach (var category in Enum.GetValues(typeof(MammalSpecies)))
                    {
                        listBoxAnimal.Items.Add(category);

                    }
                    listBoxAnimal.Update();
                }
                groupBoxMammal.Text = listBoxCategory.SelectedItem.ToString().ToUpper() + " SPECIFICATIONS:";

            }

            comboBoxReptile.Visible = false;

            textBoxTeeth.Visible = true;

            if (listBoxCategory.SelectedIndex == 0)
            {
                labelTeeth.Text = "WINGSPAN (CM): ";
                txtTail.Text = "LENGTH OF A BEAK (CM): ";
            }
            else if (listBoxCategory.SelectedIndex == 1)
            {
                comboBoxReptile.Visible = true;
                textBoxTeeth.Visible = false;
                labelTeeth.Text = "LIVES IN WATER? ";
                txtTail.Text = "WEIGHT (KG): ";

            }
            else if (listBoxCategory.SelectedIndex == 2)
            {
                labelTeeth.Text = "NO. OF TEETH: ";
                txtTail.Text = "LENGTH OF A TAIL (CM): ";
            }
            groupBoxMammal.Text = listBoxCategory.SelectedItem.ToString().ToUpper() + " SPECIFICATIONS:";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            ///Method that creates new animal object based on the data in the form
            Animal animal = ReadInput();
            CategoryType category = ReadCategory();

            manager.Add(animal, category);
            lblAnimalInfo.Text = animal.GetExtraInfo();
            ShowAllAnimals();


        }

        private Animal ReadInput()
        {
            ///Method to read user input
            CategoryType category = ReadCategory();
            Animal animal = null;

            switch (category)
            {
                case CategoryType.Mammal:
                    animal = CreateMammal();
                    break;
                case CategoryType.Reptile:
                    animal = CreateReptile();
                    break;
                case CategoryType.Bird:
                    animal = CreateBird();
                    break;
                default:
                    return null;

            }

            if (animal != null)
            { ReadCommonValues(ref animal); }
            return animal;

        }

        private void ShowAllAnimals()
        {
            int numberOfItems = manager.CurrentNumberOfItems();

            listView1.Items.Clear();
            for (int i = 0; i < numberOfItems; i++)
            {


                listView1.Items.Add(new ListViewItem(new string[] { manager.GetAnimalAt(i).Id.ToString(), manager.GetAnimalAt(i).Name.ToString(), manager.GetAnimalAt(i).Age.ToString(), manager.GetAnimalAt(i).Gender.ToString() }));
            }
        }

        private void ReadCommonValues(ref Animal animal)

        {
            // method to read common values for all animals
            animal.Name = textBoxName.Text;
            double age = 0;

            if (double.TryParse(textBoxAge.Text, out age))
            {
                animal.Age = age;
            }

            animal.Gender = (GenderType)Enum.Parse(typeof(GenderType), listBoxGender.Text);
            animal.Category = ReadCategory();
        }

        private CategoryType ReadCategory()
        {
            //method to read animal category
            CategoryType category;
            if (listBoxCategory.SelectedIndex >= 0)
                category = (CategoryType)listBoxCategory.SelectedIndex;
            else
            {
                MessageBox.Show("Please select a category!");
                category = CategoryType.Mammal;
            }
            return category;
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method to update animal species listbox
            comboBoxReptile.Visible = false;
            textBoxTeeth.Visible = true;

            if (listBoxCategory.SelectedIndex == 0)
            {
                listBoxAnimal.Items.Clear();
                labelTeeth.Text = "WINGSPAN (CM): ";
                txtTail.Text = "LENGTH OF A BEAK (CM): ";
                foreach (var category in Enum.GetValues(typeof(BirdsSpecies)))
                {
                    listBoxAnimal.Items.Add(category);
                }
                listBoxAnimal.Update();

            }
            else if (listBoxCategory.SelectedIndex == 1)
            {
                listBoxAnimal.Items.Clear();
                comboBoxReptile.Visible = true;
                textBoxTeeth.Visible = false;
                labelTeeth.Text = "LIVES IN WATER? ";
                txtTail.Text = "WEIGHT (KG): ";


                foreach (var category in Enum.GetValues(typeof(ReptileSpecies)))
                {
                    listBoxAnimal.Items.Add(category);

                }
                listBoxAnimal.Update();

            }
            else if (listBoxCategory.SelectedIndex == 2)
            {
                listBoxAnimal.Items.Clear();
                labelTeeth.Text = "NO. OF TEETH: ";
                txtTail.Text = "LENGTH OF A TAIL (CM): ";
                foreach (var category in Enum.GetValues(typeof(MammalSpecies)))
                {
                    listBoxAnimal.Items.Add(category);

                }
                listBoxAnimal.Update();
            }
            groupBoxMammal.Text = listBoxCategory.SelectedItem.ToString().ToUpper() + " SPECIFICATIONS:";

        }

        private void listBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {        

                      //method to update animal specific property groupbox based on species selected
            comboBoxReptile.Visible = false;
            textBoxTeeth.Visible = true;
            groupBoxType.Text = listBoxAnimal.SelectedItem.ToString().ToUpper() + " SPECIFICATIONS:";
            if (listBoxAnimal.SelectedItem.ToString().ToLower() == "cat" || listBoxAnimal.SelectedItem.ToString().ToLower() == "dog" || listBoxAnimal.SelectedItem.ToString().ToLower() == "horse")
                {
                groupBoxMammal.Text = "MAMMAL SPECIFICATIONS:";

                LabelSpeciesProperty.Text = "BREED: ";
                labelTeeth.Text = "NO. OF TEETH: ";
                txtTail.Text = "LENGTH OF A TAIL (CM): ";
            }
            else if (listBoxAnimal.SelectedItem.ToString().ToLower() == "lizard" || listBoxAnimal.SelectedItem.ToString().ToLower() == "snake" || listBoxAnimal.SelectedItem.ToString().ToLower() == "turtle")
                {
                groupBoxMammal.Text = "REPTILE SPECIFICATIONS:";

                LabelSpeciesProperty.Text = "COLOR: ";
                comboBoxReptile.Visible = true;
                comboBoxReptile.Items.Add("YES");
                comboBoxReptile.Items.Add("NO");
                textBoxTeeth.Visible = false;
                labelTeeth.Text = "LIVES IN WATER? ";
                txtTail.Text = "WEIGHT (KG): ";
            }
            else if (listBoxAnimal.SelectedItem.ToString().ToLower() == "dove" || listBoxAnimal.SelectedItem.ToString().ToLower() == "pigeon" || listBoxAnimal.SelectedItem.ToString().ToLower() == "eagle")
                {

                groupBoxMammal.Text = "BIRD SPECIFICATIONS:";

                LabelSpeciesProperty.Text = "COLOR: ";
                labelTeeth.Text = "WINGSPAN (CM): ";
                txtTail.Text = "LENGTH OF A BEAK (CM): ";
            }

           
        }
        private Animal CreateMammal()
        {
            // method to read Mammal and animal type specific inputs

            Animal animal = null;

            int numOfTeeth = 0;

            if (!int.TryParse(textBoxTeeth.Text, out numOfTeeth))
            {
                MessageBox.Show("Please give a valid value for number of teeth!");
            }
            double tailLength = 0;
            if (!double.TryParse(textBoxTail.Text, out tailLength))
            {
                MessageBox.Show("Please give a valid value for tail length!");
            }

            MammalSpecies species = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listBoxAnimal.Text);

            animal = MammalFactory.CreateMammal(species, numOfTeeth, tailLength);

            if (species == MammalSpecies.Dog)
            {
                ((Dog)animal).Breed = textBoxAnimalSpec.Text;
            }

            else if (species == MammalSpecies.Cat)
            {
                ((Cat)animal).Breed = textBoxAnimalSpec.Text;
            }

            else if (species == MammalSpecies.Horse)
            {
                ((Horse)animal).Breed = textBoxAnimalSpec.Text;
            }

            return animal;


        }
        private Animal CreateReptile()
        {
            // method to read Reptile specific inputs
            Animal animal = null;

            bool livesInWater = true;

            if (textBoxTeeth.Text == "YES")
            {
                livesInWater = true;
            }
            else if (textBoxTeeth.Text == "NO")
            {
                livesInWater = false;
            }


            double weight = 0.0;
            if (!double.TryParse(textBoxTail.Text, out weight))
            {
                MessageBox.Show("Please give a valid value for weight!");
            }

            ReptileSpecies species = (ReptileSpecies)Enum.Parse(typeof(ReptileSpecies), listBoxAnimal.Text);

            animal = Reptile.CreateReptile(species, weight, livesInWater);

            if (species == ReptileSpecies.Snake)
            {
                ((Snake)animal).Color = textBoxAnimalSpec.Text;
            }

            else if (species == ReptileSpecies.Lizard)
            {
                ((Lizard)animal).Color = textBoxAnimalSpec.Text;
            }
            else if (species == ReptileSpecies.Turtle)
            {
                ((Turtle)animal).Color = textBoxAnimalSpec.Text;
            }
            return animal;


        }
        private Animal CreateBird()
        {
            // method to read Bird specific inputs

            Animal animal = null;

            double wingSpan = 0;

            if (!double.TryParse(textBoxTeeth.Text, out wingSpan))
            {
                MessageBox.Show("Please give a valid value for a wingspan!");
            }
            double lengthOfBeak = 0;
            if (!double.TryParse(textBoxTail.Text, out lengthOfBeak))
            {
                MessageBox.Show("Please give a valid value for length of a beak!");
            }

            BirdsSpecies species = (BirdsSpecies)Enum.Parse(typeof(BirdsSpecies), listBoxAnimal.Text);

            animal = Bird.CreateBird(species, wingSpan, lengthOfBeak);

            if (species == BirdsSpecies.Dove)
            {
                ((Dove)animal).Color = textBoxAnimalSpec.Text;
            }

            else if (species == BirdsSpecies.Pigeon)
            {
                ((Pigeon)animal).Color = textBoxAnimalSpec.Text;
            }

            else if (species == BirdsSpecies.Eagle)
            {
                ((Eagle)animal).Color = textBoxAnimalSpec.Text;
            }

            return animal;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Method to load user image
            // open file dialog   :
            OpenFileDialog open = new OpenFileDialog();
            // image filters : 
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display and fit image in picture box:
                pictureBoxAnimal.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxAnimal.Image = new Bitmap(open.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            if (index == -1)
                return;
            IAnimal animal = manager.GetAnimalAt(index);

            listBox2.Items.Clear();
            listBox2.Items.Add("Food Schedule");
            LabelEaterType.Text = "EATER TYPE: " + animal.GetEaterType().ToString();
            foodSchedule = animal.GetFoodSchedule();
            string[] foodList = foodSchedule.GetFoodListInfoStrings();


            listBox2.Items.Clear();
            listBox2.Items.AddRange(foodList);

            lblAnimalInfo.Text = animal.GetExtraInfo();
        }
    }

}
