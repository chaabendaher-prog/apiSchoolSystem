using schoolSystem3.modes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;

namespace schoolSystem3
{
    public partial class gradee : Form

    {
        HttpClient client = new HttpClient();

        public gradee()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:7038/");

        }
        private async Task LoadGradee()
        {
            var gra = await client.GetFromJsonAsync<List<Grade>>("https://localhost:7038/api/Grade");
        }

        private async void btnAddg_Click(object sender, EventArgs e)
        {
            Grade g = new Grade()
            {
               StudentName = cmbStudent.Text,
               Exam = combExam.Text,
               Result = (int)numericUpDown1.Value
               
            };
            

            var response = await client.PostAsJsonAsync("https://localhost:7038/api/grade", g);
            MessageBox.Show(response.StatusCode.ToString());

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(" added successfully!");
                await LoadGradee();
                cmbStudent.Items.Clear();

            }


        }

        private async void btnRemoveg_Click(object sender, EventArgs e)
        {
            var response = await client.DeleteAsync(
                $"api/grade/{selectedId}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted Successfully");
                await LoadGradee();
                cmbStudent.Items.Clear();
               
            }
        }
        int selectedId = 0;
        private async void btnUpdateg_Click(object sender, EventArgs e)
        {
            
            Grade g = new Grade()
            {
                ID = selectedID,
                StudentName = cmbStudent.Text,
                Exam = combExam.Text,
                Result = (int)numericUpDown1.Value
            };

            var response = await client.PutAsJsonAsync(
                $"api/grades/{selectedID}", g);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Updated Successfully");
                await LoadGradee();
            }
           
        }
        int selectedID= 0;

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
