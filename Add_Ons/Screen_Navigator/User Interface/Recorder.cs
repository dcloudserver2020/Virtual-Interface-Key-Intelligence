using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Screen_Navigator.Module;
using static Screen_Navigator.Module.Class;

namespace Screen_Navigator.User_Interface
{
    public partial class Recorder : Form
    {
        private readonly KeyboardHook keyboardHook = new KeyboardHook();
        private readonly MouseHook mouseHook = new MouseHook();
        DateTime StartTime;
        DateTime EndTime;
        TimeSpan Delay;
        int RecordingStatus = 0;
        
        public Recorder()
        {
            InitializeComponent();
        }

        private void Recorder_Load(object sender, EventArgs e)
        {
            mouseHook.MouseMove += mouseHook_MouseMove;
            mouseHook.MouseDown += mouseHook_MouseDown;
            mouseHook.MouseUp += mouseHook_MouseUp;
            mouseHook.MouseWheel += mouseHook_MouseWheel;

            keyboardHook.KeyDown += keyboardHook_KeyDown;
            keyboardHook.KeyUp += keyboardHook_KeyUp;
            keyboardHook.KeyPress += keyboardHook_KeyPress;
        }

        private void B_Record_Click(object sender, EventArgs e)
        {
            mouseHook.Start();
            keyboardHook.Start();
            SetXYLabel(MouseSimulator.X, MouseSimulator.Y);
            StartTime = DateTime.Now;
            RecordingStatus = 1;
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            if (RecordingStatus == 0)
            {
                DataTable dt = new DataTable();
                DGV_RecordedInfo.DataSource = dt;
                dt.Rows.Clear();
                DGV_RecordedInfo.DataSource = null;
            }
        }

        private void B_Stop_Click(object sender, EventArgs e)
        {
            mouseHook.Stop();
            keyboardHook.Stop();

            int Count = 0;
            for (int i = DGV_RecordedInfo.RowCount - 1; i >= 0; i--)
            {   
                if(Count <= 2)
                {
                    if (i <= 2 & i > 0 )
                    {
                        //DGV_RecordedInfo.Row[0].Clear();
                        Count = Count + 1;
                    }                
                }
                
            }

            RecordingStatus = 0;
        }

        private void keyboardHook_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddEvent(
                "KeyPress",
                "",
                e.KeyChar.ToString(CultureInfo.InvariantCulture),
                "",
                "",
                ""
                );
        }

        private void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            AddEvent(
                "KeyUp",
                e.KeyCode.ToString(),
                "",
                "",
                "",
                ""
                );
        }

        private void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            AddEvent(
                "KeyDown",
                e.KeyCode.ToString(),
                "",
                "",
                "",
                ""
                );
        }

        private void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {
            AddEvent(
                "MouseWheel",
                "",
                "",
                "",
                "",
                e.Delta.ToString(CultureInfo.InvariantCulture)
                );
        }

        private void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {
            AddEvent(
                "MouseUp",
                e.Button.ToString(),
                "",
                e.X.ToString(CultureInfo.InvariantCulture),
                e.Y.ToString(CultureInfo.InvariantCulture),
                ""
                );
        }

        private void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            AddEvent(
                "MouseDown",
                e.Button.ToString(),
                "",
                e.X.ToString(CultureInfo.InvariantCulture),
                e.Y.ToString(CultureInfo.InvariantCulture),
                ""
                );
        }

        private void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            SetXYLabel(e.X, e.Y);
        }

        private void SetXYLabel(int x, int y)
        {
            curXYLabel.Text = String.Format("x: {0}, y: {1}", x, y);
        }

        private void AddEvent(string eventType, string keyCode, string keyChar, string x, string y, string scrool)
        {
            {
                EndTime = DateTime.Now;
                Delay = EndTime.Subtract(StartTime);
                StartTime = DateTime.Now;
            }//Add Wait Time
            {
                DGV_RecordedInfo.Rows.Insert(0,
                        eventType,
                        keyCode,
                        keyChar,
                        x,
                        y,
                        scrool,
                        Delay.ToString()
                        );
            }//Add Event

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DGV_RecordedInfo.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in DGV_RecordedInfo.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            string JsonOutput = ToJson(dt);
            System.IO.File.WriteAllText("JsonOutput.json", JsonOutput);
        }

        public string ToJson(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }
    }
}
