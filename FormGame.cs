using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormGame : Form
    {
        char[,] field;
        Image fon, stone,steve;
        int x = 1, y = 1;
        public FormGame()
        {
            InitializeComponent();
        }
        char[,] loadLevelFromFile(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string[] temp = reader.ReadLine().Split();
            int row=Convert.ToInt32(temp[0]);
            int col=Convert.ToInt32(temp[1]);
            char[,] data=new char[row,col];
            for (int i = 0; i < row; i++)
            {
                string s=reader.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    data[i, j] = s[j];
                }
                
            }
            reader.Close();
            return data;
        }


        
        void ShowField(char[,] data)
        {
        
            int widthColumn = 60;

            dataGridViewLabirint.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewLabirint.RowTemplate.Height = widthColumn;

            dataGridViewLabirint.Width = (data.GetLength(1) + 1) * (widthColumn);
            dataGridViewLabirint.Height = (data.GetLength(0) + 1) * (widthColumn);

            this.Width = dataGridViewLabirint.Width;
            this.Height = dataGridViewLabirint.Height;


            for (int i = 0; i < data.GetLength(1); i++)
            {
                var column = new DataGridViewImageColumn();
                column.Width = widthColumn;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewLabirint.Columns.Add(column);
            }

            dataGridViewLabirint.RowCount = data.GetLength(0);

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    switch (data[i, j])
                    {
                        case 'x':
                            dataGridViewLabirint.Rows[i].Cells[j].Value = stone; break;
                        case '0':
                            dataGridViewLabirint.Rows[i].Cells[j].Value = fon; break;
                            //dataGridViewLabirint[x, y].Value = fon; 
                    }

                }
            }
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            fon = Bitmap.FromFile("images/fon.png");
            stone = Bitmap.FromFile("images/stone.jpg");
            steve = Bitmap.FromFile("images/steve.png");
            field = loadLevelFromFile("levels/level1.txt");
            ShowField(field);
            dataGridViewLabirint[x, y].Value = steve;
            
        }
    }
}
