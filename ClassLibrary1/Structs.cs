using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public struct Column
    {
        Type tipo;
        Int32 length;
        String nome;
        Boolean isNull;
        Object value; //não decidio beleza

        #region Propriedades

        public Type Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Int32 Length
        {
            get { return length; }
            set { length = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

    }
}
