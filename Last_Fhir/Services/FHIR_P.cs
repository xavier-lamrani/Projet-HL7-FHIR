﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using RestSharp;

namespace Last_Fhir.Services
{
    public class FHIR_P : IPatient
    {
        const string url = "https://stu3.test.pyrohealth.net/fhir/Patient";
        public Dictionary<string, Patient> Patients = new Dictionary<string, Patient>();
        public FHIR_P()

        {
            ReadF(url);
        }


      






        public void ReadF(string url) {

            WebClient wc = new WebClient();
            
                string text = wc.DownloadString("https://stu3.test.pyrohealth.net/fhir/Patient");
            var pat = (Bundle)FhirParser.ParseResourceFromJson(text);
            
            foreach (var item in pat.Entry) {
                try
                {
  var p = (Patient)item.Resource;
                    var nbr_element  = p.Name[0].PrefixElement.Count;
                    if (nbr_element == 0)     
                   p.Name[0].PrefixElement.Add(new FhirString(""));
                    nbr_element = p.Name[0].GivenElement.Count;
                    if (nbr_element == 0)
                        p.Name[0].GivenElement.Add(new FhirString(""));
              

                Patients[p.Id]=p;
                }
                catch (Exception)
                {
                   
                    Console.WriteLine("mirda");
                 
                }
              


            }





        }

     

        public IEnumerable<Patient> findall()
        {
            return Patients.Values;
        }

        public Patient Save(Patient p)
        {

            var client = new RestClient("https://stu3.test.pyrohealth.net/fhir/Patient/" + p.Id);
            var request = new RestRequest(Method.POST);
            // request.AddHeader("Postman-Token", "ea7c0d1c-d6c1-4e80-8634-47fcfa4ae3fb");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/fhir+json");
            request.AddHeader("Accept", "application/fhir+json");
            var a = p.Id;
            var output = (new FhirJsonSerializer()).SerializeToString(p, SummaryType.False);

            // string output = JsonConvert.SerializeObject(p);

            //  var pars = (new FhirJsonParser()).Parse<p>("json") ;

            // var jsonText= FhirSerializer.SerializeResourceToJson(p);
            // var par = pat.Serialize(p);

            request.AddParameter("undefined", output, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var res = response.Content;
           // var pat = (Resource)FhirParser.ParseResourceFromJson(res);
            var pat = (Resource)FhirParser.ParseResourceFromJson(res);
            p.Id = pat.Id;

            Patients[p.Id]=p;
            return p;
        }

        public IEnumerable<Patient> PatientsParMC(string mc)
        {
            WebClient wc = new WebClient();

            string text = wc.DownloadString("https://stu3.test.pyrohealth.net/fhir/Patient?name=" + mc);
            var pat = (Bundle)FhirParser.ParseResourceFromJson(text);
            Patients.Clear();
            foreach (var item in pat.Entry)
            {
                try
                {
                    var p = (Patient)item.Resource;
                    var nbr_element = p.Name[0].PrefixElement.Count;
                    if (nbr_element == 0)
                        p.Name[0].PrefixElement.Add(new FhirString(""));
                    nbr_element = p.Name[0].GivenElement.Count;
                    if (nbr_element == 0)
                        p.Name[0].GivenElement.Add(new FhirString(""));

                
                    Patients[p.Id] = p;
                }
                catch (Exception)
                {

                    Console.WriteLine("mirda");

                }

            }
            return Patients.Values;
        }

        public Patient Getone(string ID)
        {
            
            Patient p;
            Patients.TryGetValue(ID, out p);
            return p;
     
        }

        public void Update(Patient p)
        {
            //string url = "https://stu3.test.pyrohealth.net/fhir/Patient/" + p.Id;

            // var client = new FhirClient(new Uri(url));
            //client.LastRequest.ContentType = "application/fhir+json";
            //client.Update<Patient>(p);
            //  client.Update(p);

            var client = new RestClient("https://stu3.test.pyrohealth.net/fhir/Patient/"+p.Id);
            var request = new RestRequest(Method.PUT);
           // request.AddHeader("Postman-Token", "ea7c0d1c-d6c1-4e80-8634-47fcfa4ae3fb");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/fhir+json");
            request.AddHeader("Accept", "application/fhir+json");
            var a = p.Id;
            var output = (new FhirJsonSerializer()).SerializeToString(p,SummaryType.False);

            // string output = JsonConvert.SerializeObject(p);

            //  var pars = (new FhirJsonParser()).Parse<p>("json") ;

            // var jsonText= FhirSerializer.SerializeResourceToJson(p);
            // var par = pat.Serialize(p);

            request.AddParameter("undefined", output, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);


            Patients[p.Id] = p;
        }

        public void Delete(string Id)
        {

            var client = new RestClient("https://stu3.test.pyrohealth.net/fhir/Patient/" +Id);
            var request = new RestRequest(Method.DELETE);
            // request.AddHeader("Postman-Token", "ea7c0d1c-d6c1-4e80-8634-47fcfa4ae3fb");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/fhir+json");
            request.AddHeader("Accept", "application/fhir+json");
            Patient p = Getone(Id);
            var output = (new FhirJsonSerializer()).SerializeToString(p, SummaryType.False);
            request.AddParameter("undefined", output, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Patients.Remove(Id);

        }
    }
}
