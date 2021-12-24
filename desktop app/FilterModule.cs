using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;


namespace desktop_app
{

    interface IHasId
    {
        public Guid id { get; set; }
    }

    class FilterModule<T,U> where U : IComparable<U> where T : IHasId
    {

        public delegate U Del(T _);

        /// <summary>This method filters a list of <typeparamref name="T"/> by <typeparamref name="U"/> fileld.</summary>
        /// <param name="list">list to filter</param>
        /// <param name="whichField">a delegete function that returns <typeparamref name="U"/> value from <typeparamref name="T"/>.</param>
        /// <param name="compType">type of comparason from 1 to 3</param>
        /// <param name="compVal">value to compare with</param>
        /// <returns> filtered ObservableCollection<typeparamref name="T"/>.</returns>
        public ObservableCollection<T> Filter(ObservableCollection<T> list, Del whichField , int compType, U compVal)
        {
            T.U == "XD"
            List<KeyValuePair<Guid, U> pairList = list.Select(y =>
                new KeyValuePair<Guid, U>(y.id, whichField(y))
                ).ToList();

            List < KeyValuePair < Guid, U >> filteredPairList = FilterPairList(mappedList, compType, compVal)

            return list.Where(x => 
                    filteredMappedList.Contains(x.id)
                    ).ToList()

        }

        

        private IEnumerable<Guid> FilterPairList(IEnumerable<KeyValuePair<Guid, U>> list, int type, U val) 
        {
            switch (type)
            {
                case 1:// <
                    x = list.Where(y=> y.Value.CompareTo(val)  < 0).ToList();
                    break;
                case 2:// ==
                    x = list.Where(y => y.Value.CompareTo(val) == 0).ToList();
                    break;
                case 3:// >
                    x = list.Where(y => y.Value.CompareTo(val) > 0).ToList();
                    break;
            }
            return x.Select(y => y.Key).ToList();
        }
    }
}
