namespace lab_6a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] emptyArray = new int[10];
        private int index = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            //if (index < emptyArray.Length) // Ensure we don't go out of bounds
            //{
            //    if (int.TryParse(textBox1.Text, out int number))
            //    {
            //        emptyArray[index] = number; // Add the number at index 0 (or next available)
            //        index++; // Move to the next index for future numbers
            //        MessageBox.Show($"Number {number} added at index {index - 1}.");
            //        textBox1.Clear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter a valid number.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Array is full! Cannot add more numbers.");
            //}
            int input_num;
            if (!int.TryParse(textBox1.Text, out input_num))
            {
                MessageBox.Show("Please input a number");
                return;
            }
            index++;
            Array.Resize<int>(ref emptyArray, index);
            emptyArray[index - 1] = input_num;
            listBox1.Items.Add(input_num.ToString());
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nb=0;
            foreach (int number in emptyArray)
            {
                nb += number;
            }
            label2.Text = (nb / index).ToString();
           
        }
    }
}