namespace SortingAlgorithm.Sorters 
{ 
    public class Quick 
        :ISorter 
    { 
        #region ISorter Members 
 
        public string Description 
        { 
            get { return "Quick Sort Sıralama Algoritması"; } 
        } 
 
        public void Execute(int[] Array) 
        { 
            Sort(0, Array.Length - 1,Array); 
        } 
 
        #endregion 
 
        private void Sort(int LeftValue, int RightValue,int[] Array) 
        { 
            int PivotValue, LeftHoldValue, RightHoldValue; 
 
            LeftHoldValue = LeftValue; 
            RightHoldValue = RightValue; 
            PivotValue = Array[LeftValue]; 
 
            while (LeftValue < RightValue) 
            { 
                while ((Array[RightValue] >= PivotValue) && (LeftValue < RightValue)) 
                { 
                    RightValue--; 
                } 
 
                if (LeftValue != RightValue) 
                { 
                    Array[LeftValue] = Array[RightValue]; 
                    LeftValue++; 
                } 
 
                while ((Array[LeftValue] <= PivotValue) && (LeftValue < RightValue)) 
                { 
                    LeftValue++; 
                } 
 
                if (LeftValue != RightValue) 
                { 
                    Array[RightValue] = Array[LeftValue]; 
                    RightValue--; 
                } 
            } 
 
            Array[LeftValue] = PivotValue; 
            PivotValue = LeftValue; 
            LeftValue = LeftHoldValue; 
            RightValue = RightHoldValue; 
 
            if (LeftValue < PivotValue) 
            { 
                Sort(LeftValue, PivotValue - 1,Array); 
            } 
 
            if (RightValue > PivotValue) 
            { 
                Sort(PivotValue + 1, RightValue,Array); 
            } 
        } 
    } 
}