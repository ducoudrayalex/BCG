using System;

namespace BCG
{
    class Matrice
    {
        private String _activite;
        private float _PDMproduit;
        private float _PDMconcu;
        private float _txCroiss;
        private float _partProduit;

        public String toString()
        {
            return _activite + " " + _PDMproduit + " " + _PDMconcu + " " + _txCroiss + " " + _partProduit;
        }
        public Matrice()
        {

        }
        public string Activite
        {
            get
            {
                return _activite;
            }

            set
            {
                _activite = value;
            }
        }

        public float PDMproduit
        {
            get
            {
                return _PDMproduit;
            }

            set
            {
                _PDMproduit = value;
            }
        }

        public float PDMconcu
        {
            get
            {
                return _PDMconcu;
            }

            set
            {
                _PDMconcu = value;
            }
        }

        public float TxCroiss
        {
            get
            {
                return _txCroiss;
            }

            set
            {
                _txCroiss = value;
            }
        }

        public float PartProduit
        {
            get
            {
                return _partProduit;
            }

            set
            {
                _partProduit = value;
            }
        }

        public Matrice(String activite,float PDMProduit,float PDMconcu,float txCroiss,float partProduit)
        {
            Activite = activite;
            this.PDMconcu = PDMconcu;
            PDMproduit = PDMProduit;
            TxCroiss = txCroiss;
            PartProduit = partProduit;
        }
       
    }
}
