﻿using Locadora.WebApp.Domain.Models;
using System;
using System.Globalization;

namespace Locadora.WebApp.ViewModel
{
    public class ClientViewModel
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string dataNascimento { get; set; }
        public string celular { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public static ClienteModel MapClientDTOToModel(ClientViewModel clienteModel)
        {
            DateTime dataNascimento;
            var okDtNascimento = DateTime.TryParseExact(clienteModel.dataNascimento, new string[] { "yyyy-MM-dd", "yyyy/MM/dd" },
                                                         CultureInfo.CurrentCulture, DateTimeStyles.None, out dataNascimento);
            return new ClienteModel()
            {
                Nome = clienteModel.nome,
                Cpf = clienteModel.cpf,
                Sexo = clienteModel.sexo,
                DataNascimento = okDtNascimento ? dataNascimento : DateTime.Now,
                Contato = new ContactModel
                {
                    Email = clienteModel.email,
                    Celular = clienteModel.celular
                },
                Endereco = new AddressModel
                {
                    Endereco = clienteModel.endereco,
                    Numero = clienteModel.numero,
                    Bairro = clienteModel.bairro,
                    CEP = clienteModel.cep,
                    Cidade = clienteModel.cidade,
                    Estado = clienteModel.estado
                }
            };
        }
        public static ClientViewModel MapModelToClienteDTO(ClienteModel clienteModel)
        {
            return new ClientViewModel()
            {
                nome = clienteModel.Nome,
                cpf = clienteModel.Cpf,
                sexo = clienteModel.Sexo,
                dataNascimento = clienteModel.DataNascimento.ToString(),
                email = clienteModel.Contato.Email,
                celular = clienteModel.Contato.Celular,
                endereco = clienteModel.Endereco.Endereco,
                numero = clienteModel.Endereco.Numero,
                bairro = clienteModel.Endereco.Bairro,
                cep = clienteModel.Endereco.CEP,
                cidade = clienteModel.Endereco.Cidade,
                estado = clienteModel.Endereco.Estado
            };
        }
    }
}
