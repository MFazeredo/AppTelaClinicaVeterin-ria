using System;
using System.Collections.Generic;
using System.Text;

namespace AppTelaClinicaVeterinária
{
    class BffUsuario
    {
        public EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();
        private BackEndBFFUsuario BackEndBFFUsuario = new BackEndBFFUsuario();

        public bool inserir()
        {
            return BackEndBFFUsuario.inserir(objEntidadeUsuario.Nome, objEntidadeUsuario.Email, objEntidadeUsuario.Senha, objEntidadeUsuario.ConfSenha, objEntidadeUsuario.Endereco, objEntidadeUsuario.Telefone, objEntidadeUsuario.Pet);
        }

        public bool alterar()
        {
            return BackEndBFFUsuario.AlterarUsuario(objEntidadeUsuario.Id.Value, objEntidadeUsuario.Nome, objEntidadeUsuario.Email, objEntidadeUsuario.Senha, objEntidadeUsuario.ConfSenha, objEntidadeUsuario.Endereco, objEntidadeUsuario.Telefone, objEntidadeUsuario.Pet);
        }

        public bool Excluir(int id)
        {
            return BackEndBFFUsuario.Excluir(id);
        }

        public List<EntidadeUsuario> Listar()
        {
            return BackEndBFFUsuario.Listar();
        }

        public EntidadeUsuario Listar(int id)
        {
            return BackEndBFFUsuario.Listar(id);
        }
    }
}
