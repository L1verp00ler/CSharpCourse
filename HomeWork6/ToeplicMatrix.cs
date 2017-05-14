﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class ToeplicMatrix : Matrix
    {
        private int[] firstRow;
        private int[] firstCol;

        public override int this[uint col, uint row]
        {
            get
            {
                uint minIndex = Math.Min(col, row);

                col -= minIndex;
                row -= minIndex;

                if ((col == 0 && row == 0) || (col > 0))
                {
                    return firstRow[col];
                }

                return firstCol[row - 1];
            }
            set
            {
                uint minIndex = Math.Min(col, row);

                col -= minIndex;
                row -= minIndex;

                if ((col == 0 && row == 0) || (col > 0))
                {
                    firstRow[col] = value;
                    return;
                }

                firstCol[row - 1] = value;
            }
        }

        public ToeplicMatrix(uint colCount, uint rowCount)
            : base(colCount, rowCount)
        {
        }

        protected override void InitData()
        {
            firstRow = new int[ColCount];
            firstCol = new int[RowCount - 1];
        }

        public override Matrix Sum(Matrix otherMatrix)
        {
            ToeplicMatrix tMat = otherMatrix as ToeplicMatrix;
            if (tMat == null)
                return base.Sum(otherMatrix);

            // TODO проверки
            ToeplicMatrix sumResult = new ToeplicMatrix(ColCount, RowCount);
            for (int col = 0; col < ColCount; col++)
            {
                sumResult.firstRow[col] = firstRow[col] + tMat.firstRow[col];
            }

            for (int row = 0; row < RowCount - 1; row++)
            {
                sumResult.firstCol[row] = firstCol[row] + tMat.firstCol[row];
            }

            return sumResult;
        }
    }
}
