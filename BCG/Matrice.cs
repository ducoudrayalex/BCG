using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCG
{
    class Matrice
    {
        private String _activite;
        private float _PDMproduit;
        private float _PDMconct;
        private float _txCroiss;
        private float _partProduit;
        public String toString()
        {
            return _activite + " " + _PDMproduit + " " + _PDMconct + " " + _txCroiss + " " + _partProduit;
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

        public float PDMconct
        {
            get
            {
                return _PDMconct;
            }

            set
            {
                _PDMconct = value;
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

        public Matrice(String activite,float PDMProduit,float PDMconct,float txCroiss,float partProduit)
        {
            Activite = activite;
            this.PDMconct = PDMconct;
            PDMproduit = PDMProduit;
            TxCroiss = txCroiss;
            PartProduit = partProduit;
        }
       
    }
}
