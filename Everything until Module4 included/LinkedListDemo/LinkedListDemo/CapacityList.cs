using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class CapacityList
    {

        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            //TODO: сумирайте двойките от startIndex до nextIndex
        }

        public Pair Sum()
        {
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
        }

        public void Add(Pair item)
        {
            //TODO: Добавяне на двойката         
        }

        public void PrintCurrentState()
        {
            //TODO: отпечатайте всички двойки от 0 до nextIndex
        }


    }
}
