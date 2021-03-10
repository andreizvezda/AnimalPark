/// MainForm.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections;
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
        private readonly AnimalManager manager = new AnimalManager();
        private FoodSchedule foodSchedule = new FoodSchedule();
        private readonly ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        public MainForm()
        {
            InitializeComponent();
            //My initializations:
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
            ColumnHeaders();


        }

        private void ColumnHeaders()
        {
            //Method to add columns to ListView
            ColumnHeader columnheader;
            columnheader = new ColumnHeader
            {
                Text = " ID "
            };
            this.listView1.Columns.Add(columnheader);

            columnheader = new ColumnHeader
            {
                Text = " NAME "
            };
            this.listView1.Columns.Add(columnheader);
            columnheader = new ColumnHeader
            {
                Text = " AGE "
            };
            this.listView1.Columns.Add(columnheader);

            columnheader = new ColumnHeader
            {
                Text = " GENDER "
            };
            this.listView1.Columns.Add(columnheader);

            columnheader = new ColumnHeader
            {
                Text = " SPECIES "
            };
            this.listView1.Columns.Add(columnheader);

            foreach (ColumnHeader ch in this.listView1.Columns)
            {
                ch.Width = -2;
            }

        }
        private void CheckBoxAnimals_CheckedChanged(object sender, EventArgs e)
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

        private Animal ReadInput()
        {
            ///Method to read user input
            CategoryType category = ReadCategory();
            Animal animal;
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

        private void ReadCommonValues(ref Animal animal)

        {
            // method to read common values for all animals
            animal.Name = textBoxName.Text;

            if (double.TryParse(textBoxAge.Text, out double age))
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
        private void ShowAllAnimals()
        {
            //Method to show animals in ListView:

            int numberOfItems = manager.CurrentNumberOfItems();

            listView1.Items.Clear();
            for (int i = 0; i < numberOfItems; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { manager.GetAnimalAt(i).Id.ToString(), manager.GetAnimalAt(i).Name.ToString(), manager.GetAnimalAt(i).Age.ToString(), manager.GetAnimalAt(i).Gender.ToString(), manager.GetAnimalAt(i).GetSpecies()}));
            }
        }

        private Animal CreateMammal()
        {
            if (!int.TryParse(textBoxTeeth.Text, out int numOfTeeth))
            {
                MessageBox.Show("Please give a valid value for number of teeth!");
            }
            if (!double.TryParse(textBoxTail.Text, out double tailLength))
            {
                MessageBox.Show("Please give a valid value for tail length!");
            }

            MammalSpecies species = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listBoxAnimal.Text);

            // method to read Mammal and animal type specific inputs

            Animal animal = Mammal.CreateMammal(species, numOfTeeth, tailLength);
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
            bool livesInWater = true;

            if (textBoxTeeth.Text == "YES")
            {
                livesInWater = true;
            }
            else if (textBoxTeeth.Text == "NO")
            {
                livesInWater = false;
            }


            if (!double.TryParse(textBoxTail.Text, out double weight))
            {
                MessageBox.Show("Please give a valid value for weight!");
            }

            ReptileSpecies species = (ReptileSpecies)Enum.Parse(typeof(ReptileSpecies), listBoxAnimal.Text);

            // method to read Reptile specific inputs
            Animal animal = Reptile.CreateReptile(species, weight, livesInWater);
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
            if (!double.TryParse(textBoxTeeth.Text, out double wingSpan))
            {
                MessageBox.Show("Please give a valid value for a wingspan!");
            }
            if (!double.TryParse(textBoxTail.Text, out double lengthOfBeak))
            {
                MessageBox.Show("Please give a valid value for length of a beak!");
            }

            BirdsSpecies species = (BirdsSpecies)Enum.Parse(typeof(BirdsSpecies), listBoxAnimal.Text);

            // method to read Bird specific inputs

            Animal animal = Bird.CreateBird(species, wingSpan, lengthOfBeak);
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

            ///Method that creates new animal object based on the data in the form
            Animal animal = ReadInput();
            CategoryType category = ReadCategory();

            manager.Add(animal, category);
            lblAnimalInfo.Text = animal.GetExtraInfo();
            ShowAllAnimals();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Method to load user image
            // open file dialog   :
            OpenFileDialog open = new OpenFileDialog
            {
                // image filters : 
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display and fit image in picture box:
                pictureBoxAnimal.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxAnimal.Image = new Bitmap(open.FileName);
            }
        }
        private void ListBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ListBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //method to update foodchedule groupbox based on animal selected


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
        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Method to sort based on columns

            this.listView1.ListViewItemSorter = lvwColumnSorter;

            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            listView1.Sort();
        }
    }

}
