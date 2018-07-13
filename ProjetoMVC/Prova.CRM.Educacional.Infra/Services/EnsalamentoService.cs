namespace Prova.CRM.Educacional.Infra.Services
{
    using System;
    using System.Collections.Generic;
    using Domain.Interfaces.Services;
    using Domain.Entities;
    using System.IO;

    public class EnsalamentoService : IEnsalamentoService
    {
        public List<Sala> DistribuirCandidatos(string fileName)
        {
            var candidatos = CarregaCandidatos(fileName);
            var salas = CriarSalas();
            int indiceSala = 0;
            var totalSalas = salas.Count;

            foreach (var candidato in candidatos)
            {
                var sala = ObterSalaDisponivel(salas, indiceSala);

                if (sala != null)
                    sala.AdicionaCandidato(candidato);

                if (indiceSala == salas.Count - 1)
                    indiceSala = 0;

            }

            return salas;
        }

        private List<Candidato> CarregaCandidatos(string path)
        {
            var candidatos = new List<Candidato>();
            using (var reader = new StreamReader(path))
            {
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (values[0] == "NomeCompleto")
                        continue;

                    candidatos.Add(new Candidato
                    {
                        NomeCompleto = values[0],
                        Sexo = values[1],
                        Afinidade = Convert.ToInt32(values[2])
                    });
                }
            }

            return candidatos;
        }

        private List<Sala> CriarSalas()
        {
            var salas = new List<Sala>();
            for (int i = 1; i <= 10; i++)
                salas.Add(new Sala
                {
                    NomeSala = $"Sala - {i}",
                    VagasDisponiveis = i * 10,
                    TotalVagas = i * 10
                });

            return salas;
        }

        private Sala ObterSalaDisponivel(List<Sala> salas, int indiceSala)
        {
            for (int i = indiceSala; i < salas.Count; i++)
            {
                if (salas[i].VagasDisponiveis > 0)
                {
                    indiceSala++;
                    return salas[i];
                }
            }

            return null;
        }
    }
}
