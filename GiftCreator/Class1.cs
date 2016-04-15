using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCreator
{
    class Gift : ICollection<IGiftItem>
    {
    
        private ICollection<IGiftItem> giftItem= new List<IGiftItem>();


        public void Add(IGiftItem item)
        {
            giftItem.Add(item);
        }

        public void Clear()
        {
            giftItem.Clear();
        }

        public bool Contains(IGiftItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IGiftItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(IGiftItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IGiftItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
