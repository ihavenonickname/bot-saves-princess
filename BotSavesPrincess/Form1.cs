﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BotSavesPrincess
{
    public partial class Form1 : Form
    {
        private const int CELL_SIZE = 15;
        private const int ROWS_COUNT = 45;
        private const int COLS_COUNT = 70;

        private readonly Color cleanColor = Color.FromKnownColor(KnownColor.Control);
        private readonly Color heroColor = Color.Blue;
        private readonly Color princessColor = Color.Pink;
        private readonly Color wallColor = Color.Gray;
        private readonly Color pathColor = Color.LawnGreen;

        private Position _heroPosition = null;
        private Position _princessPosition = null;

        public Form1()
        {
            InitializeComponent();

            for (var i = 0; i < COLS_COUNT; i++)
            {
                int index = dgvBoard.Columns.Add("", "");

                dgvBoard.Columns[index].Width = CELL_SIZE;
            }

            for (var i = 0; i < ROWS_COUNT; i++)
            {
                int index = dgvBoard.Rows.Add();

                dgvBoard.Rows[index].Height = CELL_SIZE;
            }
            
            dgvBoard.Width = CELL_SIZE * COLS_COUNT + 3;
            dgvBoard.Height = CELL_SIZE * ROWS_COUNT + 3;

            Width = dgvBoard.Width + 50;
            Height = dgvBoard.Height + 120;

            dgvBoard.CellClick += dgvBoard_CellClick;

            wrkFinder.RunWorkerCompleted += wrkFinder_RunWorkerCompleted;
        }

        private void wrkFinder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var path = (IEnumerable<Position>)e.Result;

            if (path != null)
            {
                foreach (var pos in path)
                {
                    changeColor(pos.Row, pos.Column, pathColor);
                }
            }
            else
            {
                MessageBox.Show("No path found");
            }
        }

        private void dgvBoard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var pos = new Position(e.RowIndex, e.ColumnIndex);

            if (radWall.Checked)
            {
                changeColor(pos.Row, pos.Column, wallColor);
            }
            else if (radClean.Checked)
            {
                changeColor(pos.Row, pos.Column, cleanColor);
            }
            else if (radHero.Checked)
            {
                if (pos == _heroPosition)
                {
                    return;
                }

                changeColor(pos.Row, pos.Column, heroColor);

                if (_heroPosition != null)
                {
                    changeColor(_heroPosition.Row, _heroPosition.Column, cleanColor);
                }

                _heroPosition = pos;
            }
            else
            {
                if (pos == _princessPosition)
                {
                    return;
                }

                changeColor(pos.Row, pos.Column, princessColor);

                if (_princessPosition != null)
                {
                    changeColor(_princessPosition.Row, _princessPosition.Column, cleanColor);
                }

                _princessPosition = pos;
            }
        }

        private void changeColor(int row, int col, Color color)
        {
            dgvBoard.Rows[row].Cells[col].Style.BackColor = color;
            dgvBoard.Rows[row].Cells[col].Style.SelectionBackColor = color;
        }

        private void wrkFinder_DoWork(object sender, DoWorkEventArgs e)
        {
            var walls = new HashSet<Position>();

            for (var row = 0; row < ROWS_COUNT; row++)
            {
                for (var column = 0; column < COLS_COUNT; column++)
                {
                    if (dgvBoard.Rows[row].Cells[column].Style.BackColor == wallColor)
                    {
                        walls.Add(new Position(row, column));
                    }
                }
            }

            var finder = new Finder(ROWS_COUNT - 1, COLS_COUNT - 1);

            var path = finder.findPath(_heroPosition, _princessPosition, walls);

            e.Result = path;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_heroPosition == null)
            {
                MessageBox.Show("Set the hero's position");

                return;
            }

            if (_princessPosition == null)
            {
                MessageBox.Show("Set the princess' position");

                return;
            }

            for (var row = 0; row < ROWS_COUNT; row++)
            {
                for (var column = 0; column < COLS_COUNT; column++)
                {
                    if (dgvBoard.Rows[row].Cells[column].Style.BackColor == pathColor)
                    {
                        changeColor(row, column, cleanColor);
                    }
                }
            }

            wrkFinder.RunWorkerAsync();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            for (var row = 0; row < ROWS_COUNT; row++)
            {
                for (var column = 0; column < COLS_COUNT; column++)
                {
                    changeColor(row, column, cleanColor);
                }
            }

            _heroPosition = null;
            _princessPosition = null;
        }
    }
}