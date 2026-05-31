using schoolSystem3.modes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace schoolSystem3
{
    public partial class Students : Form
    {

        HttpClient client = new HttpClient();

        public Students()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:7038/");

        }
        private async Task LoadStudents()
        {
            var students = await client.GetFromJsonAsync<List<Student>>("api/Student");
        }

        private async void btnAddc_Click(object sender, EventArgs e)
        {

            Student s = new Student();
            {
                Name = txtStudentc.Text;
                //      = txtclassec.Text;
            }
            ;

            var response = await client.PostAsJsonAsync("https://localhost:7038/api/Student", s);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Student added successfully!");
                await LoadStudents();
                txtStudentc.Clear();
                txtclassec.Clear();
            }

        }

        private async void btnUpdatec_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                Id = selectedId,
                Name = txtStudentc.Text,
                Class = txtclassec.Text
            };

            var response = await client.PutAsJsonAsync(
                $"api/students/{selectedId}", s);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Updated Successfully");
                await LoadStudents();
            }
        }
        int selectedId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                txtStudentc.Text =
                    row.Cells["Name"].Value.ToString();

                txtclassec.Text =
                    row.Cells["Class"].Value.ToString();
            }
        }

        private async void btnRemovec_Click(object sender, EventArgs e)
        {
            var response = await client.DeleteAsync(
                $"api/students/{selectedId}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted Successfully");
                await LoadStudents();
                txtStudentc.Clear();
                txtclassec.Clear();
            }
        }
    }
}
