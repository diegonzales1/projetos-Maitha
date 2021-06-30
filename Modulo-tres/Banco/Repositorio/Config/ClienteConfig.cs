﻿using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            // Não permite campo vazio
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.CPFCNPJ).IsRequired();

            // Muitos para um 
            builder.HasMany(c => c.Contatos).WithOne(c => c.Cliente);

        }
    }
}
