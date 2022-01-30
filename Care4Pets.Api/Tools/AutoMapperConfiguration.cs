using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Care4Pets.Api.Bol;
using Care4Pets.Api.Bol.DTOs;

namespace Care4Pets.Api.Tools
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            return new MapperConfiguration(configuration =>
            {
                #region MapperConfiguration for Medication Entity 
                configuration.CreateMap<Medication, MedicationDTO>();
                configuration.CreateMap<MedicationDTO, Medication>();

                configuration.CreateMap<Medication, RawMedicationDTO>();
                configuration.CreateMap<RawMedicationDTO, Medication>();

                configuration.CreateMap<Medication, CustomMedicationDTO>()
                .ForMember(destination => destination.AdministrationWay, map => map.MapFrom(source => source.AdministrationWay.Name))
                .ForMember(destination => destination.Presentation, map => map.MapFrom(source => source.MedicationPresentation.Name));
                #endregion
            });
        }
    }
}