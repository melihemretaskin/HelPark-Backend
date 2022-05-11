using HelPark.Models.IsParkDTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using HelPark.Business.Interfaces;
using HelPark.DataAccess.Repository;

namespace HelPark.Business.IsPark
{
    public class IsParkService : IIsParkService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IsParkDetailRepository isParkDetailRepository;
        private readonly IsParkRepository isParkRepository;

        public IsParkService(IHttpClientFactory clientFactory, IsParkDetailRepository isParkDetailRepository,IsParkRepository isParkRepository)
        {
            _clientFactory = clientFactory;
            this.isParkDetailRepository = isParkDetailRepository;
            this.isParkRepository = isParkRepository;
        }

        public IsParkDetail GetIsParkDetailById(int id)
        {
            IsParkDetail isParkDetail = new IsParkDetail();

            using (var client = _clientFactory.CreateClient("IsPark"))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"ParkDetay?id={id}");
                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = response.Content.ReadAsStream();

                    StreamReader reader = new StreamReader(responseStream);
                    var result = reader.ReadToEnd();

                    isParkDetail = JsonConvert.DeserializeObject<List<IsParkDetail>>(result)?.FirstOrDefault();

                    isParkDetailRepository.InsertOne(isParkDetail);

                    //isParkDetailRepository.UpdateOne(isParkDetail);
                }
            }

            return isParkDetail;
        }
        public List<Models.IsParkDTO.IsPark> GetIsPark()
        {
            List<Models.IsParkDTO.IsPark> isParkList = new List<Models.IsParkDTO.IsPark>();
            using (var client = _clientFactory.CreateClient("IsPark"))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"Park");
                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = response.Content.ReadAsStream();

                    StreamReader reader = new StreamReader(responseStream);
                    var result = reader.ReadToEnd();

                    isParkList = JsonConvert.DeserializeObject<List<Models.IsParkDTO.IsPark>>(result);

                    isParkRepository.InsertMany(isParkList);
                }
                #region Log
                else
                {
                    using var responseStream = response.Content.ReadAsStream();

                    StreamReader reader = new StreamReader(responseStream);
                    var result = reader.ReadToEnd();//Hata kodu burda -> result

                    //Log(result);
                }
                #endregion

            }

            return isParkList;
        }
    }
}
