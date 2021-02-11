﻿using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                (
                    Convert.ToInt64(gamer.NationalityNo),
                    Ad: gamer.FirstName,
                    Soyad: gamer.LastName,
                    DogumYili: gamer.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
