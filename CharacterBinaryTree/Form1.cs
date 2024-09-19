using CharacterBinaryTree;
namespace CharacterBinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPower_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {

        }
        private BinarySearchTree<Character> characterTree = new BinarySearchTree<Character>();

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int power = int.Parse(txtPower.Text);
            int speed = int.Parse(txtSpeed.Text);

            Character newCharacter = new Character(name, power, speed);
            characterTree.Insert(newCharacter);
            UpdateCharacterList();  

            txtName.Clear(); 
            txtPower.Clear();
            txtSpeed.Clear();
           
        }

        private void UpdateCharacterList()  
        {
            lstCharacters.Items.Clear();  
            characterTree.InOrderTraversal(character =>
            {
                lstCharacters.Items.Add(character.ToString());
            });
        }


        private void lstCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
