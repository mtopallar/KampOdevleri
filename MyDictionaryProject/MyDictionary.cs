using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] _key;
        private TValue[] _value;
        private TKey[] _tempKey;
        private TValue[] _tempValue;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKey = new TKey[0];
            _tempValue = new TValue[0];

            _tempKey = _key;
            _tempValue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {

                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];

                // key / value çift olarak tutulduğu için tempkey in lenght'i ile tempvalue nun lenght'i aynı olacaktır. key veya anahtarı girmek zaten zorunlu. key yoksa value da yok. sadece key veya sadece value girersek eksik parametreden ötürü zaten hata alırız.

            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;

        }

        public int Count // test için oluşturuldu. sözlüğümüz henüz bir indexer içermiyor ve iterate edilebilir değil.
        {

            get
            {
                return _key.Length;

            }

        }
    }
}
