




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
#pragma warning disable 219 //The variable 'lower_limit' is assigned but its value is never used
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Tests RQL json parsing

    [TestFixture]
    public class Json : YamlTestFixture {

        public Json (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjQiLCJPcmlnaW5hbCI6InIuanNvbihcIlsxLDIsM11cIikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmpzb24oXCJbMSwyLDNdXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlsxLDIsM10iLCJFeHBlY3RlZFR5cGUiOiJMaXN0IiwiRXhwZWN0ZWRKYXZhIjoici5hcnJheSgxTCwgMkwsIDNMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, json.yaml, #4
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.json("[1,2,3]") */
                 var obtained = runOrCatch( r.json("[1,2,3]") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjciLCJPcmlnaW5hbCI6InIuanNvbihcIjFcIikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmpzb24oXCIxXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjEiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMUwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, json.yaml, #7
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.json("1") */
                 var obtained = runOrCatch( r.json("1") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjEwIiwiT3JpZ2luYWwiOiJyLmpzb24oXCJ7fVwiKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuanNvbihcInt9XCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Int9IiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, json.yaml, #10
                 /* ExpectedOriginal: {} */
                 var expected_ = r.hashMap();
                 
                 /* Original: r.json("{}") */
                 var obtained = runOrCatch( r.json("{}") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjEzIiwiT3JpZ2luYWwiOiJyLmpzb24oJ1wiZm9vXCInKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuanNvbihcIlxcXCJmb29cXFwiXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlwiZm9vXCIiLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcImZvb1wiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #13
                 /* ExpectedOriginal: "foo" */
                 var expected_ = "foo";
                 
                 /* Original: r.json('"foo"') */
                 var obtained = runOrCatch( r.json("\"foo\"") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjE2IiwiT3JpZ2luYWwiOiJyLmpzb24oXCJbMSwyXCIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5qc29uKFwiWzEsMlwiKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsICdGYWlsZWQgdG8gcGFyc2UgXCJbMSwyXCIgYXMgSlNPTjonICsgJyBNaXNzaW5nIGEgY29tbWEgb3IgXFwnXVxcJyBhZnRlciBhbiBhcnJheSBlbGVtZW50LicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRmFpbGVkIHRvIHBhcnNlIFxcXCJbMSwyXFxcIiBhcyBKU09OOlwiICsgXCIgTWlzc2luZyBhIGNvbW1hIG9yICddJyBhZnRlciBhbiBhcnJheSBlbGVtZW50LlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, json.yaml, #16
                 /* ExpectedOriginal: err("ReqlQueryLogicError", 'Failed to parse "[1,2" as JSON:' + ' Missing a comma or \']\' after an array element.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Failed to parse \"[1,2\" as JSON:" + " Missing a comma or ']' after an array element.", r.array(0L));
                 
                 /* Original: r.json("[1,2") */
                 var obtained = runOrCatch( r.json("[1,2") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjE5IiwiT3JpZ2luYWwiOiJyLmpzb24oXCJbMSwyLDNdXCIpLnRvX2pzb25fc3RyaW5nKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmpzb24oXCJbMSwyLDNdXCIpLnRvSnNvblN0cmluZygpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlsxLDIsM10iLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcIlsxLDIsM11cIiIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, json.yaml, #19
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = "[1,2,3]";
                 
                 /* Original: r.json("[1,2,3]").to_json_string() */
                 var obtained = runOrCatch( r.json("[1,2,3]").toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjIzIiwiT3JpZ2luYWwiOiJyLmpzb24oXCJbMSwyLDNdXCIpLnRvX2pzb24oKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuanNvbihcIlsxLDIsM11cIikudG9Kc29uKCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiWzEsMiwzXSIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6IlwiWzEsMiwzXVwiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #23
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = "[1,2,3]";
                 
                 /* Original: r.json("[1,2,3]").to_json() */
                 var obtained = runOrCatch( r.json("[1,2,3]").toJson() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjI2IiwiT3JpZ2luYWwiOiJyLmpzb24oXCJ7XFxcImZvb1xcXCI6NH1cIikudG9fanNvbl9zdHJpbmcoKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuanNvbihcIntcXFwiZm9vXFxcIjo0fVwiKS50b0pzb25TdHJpbmcoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7XCJmb29cIjo0fSIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6Ilwie1xcXCJmb29cXFwiOjR9XCIiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, json.yaml, #26
                 /* ExpectedOriginal: {"foo":4} */
                 var expected_ = "{\"foo\":4}";
                 
                 /* Original: r.json("{\"foo\":4}").to_json_string() */
                 var obtained = runOrCatch( r.json("{\"foo\":4}").toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjMwIiwiT3JpZ2luYWwiOiJyLmpzb24oXCJ7XFxcImZvb1xcXCI6NH1cIikudG9fanNvbigpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5qc29uKFwie1xcXCJmb29cXFwiOjR9XCIpLnRvSnNvbigpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IntcImZvb1wiOjR9IiwiRXhwZWN0ZWRUeXBlIjoiU3RyaW5nIiwiRXhwZWN0ZWRKYXZhIjoiXCJ7XFxcImZvb1xcXCI6NH1cIiIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, json.yaml, #30
                 /* ExpectedOriginal: {"foo":4} */
                 var expected_ = "{\"foo\":4}";
                 
                 /* Original: r.json("{\"foo\":4}").to_json() */
                 var obtained = runOrCatch( r.json("{\"foo\":4}").toJson() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, json.yaml, #34
             //Original: text = '[{"id":1,"first_name":"Harry","last_name":"Riley","email":"hriley0@usgs.gov","country":"Andorra","ip_address":"221.25.65.136"},{"id":2,"first_name":"Bonnie","last_name":"Anderson","email":"banderson1@list-manage.com","country":"Tuvalu","ip_address":"116.162.43.150"},{"id":3,"first_name":"Marie","last_name":"Schmidt","email":"mschmidt2@diigo.com","country":"Iraq","ip_address":"181.105.59.57"},{"id":4,"first_name":"Phillip","last_name":"Willis","email":"pwillis3@com.com","country":"Montenegro","ip_address":"24.223.139.156"}]'
             
                 var text = (String) ("[{\"id\":1,\"first_name\":\"Harry\",\"last_name\":\"Riley\",\"email\":\"hriley0@usgs.gov\",\"country\":\"Andorra\",\"ip_address\":\"221.25.65.136\"},{\"id\":2,\"first_name\":\"Bonnie\",\"last_name\":\"Anderson\",\"email\":\"banderson1@list-manage.com\",\"country\":\"Tuvalu\",\"ip_address\":\"116.162.43.150\"},{\"id\":3,\"first_name\":\"Marie\",\"last_name\":\"Schmidt\",\"email\":\"mschmidt2@diigo.com\",\"country\":\"Iraq\",\"ip_address\":\"181.105.59.57\"},{\"id\":4,\"first_name\":\"Phillip\",\"last_name\":\"Willis\",\"email\":\"pwillis3@com.com\",\"country\":\"Montenegro\",\"ip_address\":\"24.223.139.156\"}]");
             
             
             //JavaDef, json.yaml, #35
             //Original: sorted = '[{"country":"Andorra","email":"hriley0@usgs.gov","first_name":"Harry","id":1,"ip_address":"221.25.65.136","last_name":"Riley"},{"country":"Tuvalu","email":"banderson1@list-manage.com","first_name":"Bonnie","id":2,"ip_address":"116.162.43.150","last_name":"Anderson"},{"country":"Iraq","email":"mschmidt2@diigo.com","first_name":"Marie","id":3,"ip_address":"181.105.59.57","last_name":"Schmidt"},{"country":"Montenegro","email":"pwillis3@com.com","first_name":"Phillip","id":4,"ip_address":"24.223.139.156","last_name":"Willis"}]'
             
                 var sorted = (String) ("[{\"country\":\"Andorra\",\"email\":\"hriley0@usgs.gov\",\"first_name\":\"Harry\",\"id\":1,\"ip_address\":\"221.25.65.136\",\"last_name\":\"Riley\"},{\"country\":\"Tuvalu\",\"email\":\"banderson1@list-manage.com\",\"first_name\":\"Bonnie\",\"id\":2,\"ip_address\":\"116.162.43.150\",\"last_name\":\"Anderson\"},{\"country\":\"Iraq\",\"email\":\"mschmidt2@diigo.com\",\"first_name\":\"Marie\",\"id\":3,\"ip_address\":\"181.105.59.57\",\"last_name\":\"Schmidt\"},{\"country\":\"Montenegro\",\"email\":\"pwillis3@com.com\",\"first_name\":\"Phillip\",\"id\":4,\"ip_address\":\"24.223.139.156\",\"last_name\":\"Willis\"}]");
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjM3IiwiT3JpZ2luYWwiOiJyLmpzb24odGV4dCkudG9fanNvbl9zdHJpbmcoKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuanNvbih0ZXh0KS50b0pzb25TdHJpbmcoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJzb3J0ZWQiLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJzb3J0ZWQiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, json.yaml, #37
                 /* ExpectedOriginal: sorted */
                 var expected_ = sorted;
                 
                 /* Original: r.json(text).to_json_string() */
                 var obtained = runOrCatch( r.json(text).toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjQwIiwiT3JpZ2luYWwiOiJyLmV4cHIoci5taW52YWwpLnRvX2pzb25fc3RyaW5nKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5taW52YWwoKSkudG9Kc29uU3RyaW5nKCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0Nhbm5vdCBjb252ZXJ0IGByLm1pbnZhbGAgdG8gSlNPTi4nKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJDYW5ub3QgY29udmVydCBgci5taW52YWxgIHRvIEpTT04uXCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #40
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.minval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 /* Original: r.expr(r.minval).to_json_string() */
                 var obtained = runOrCatch( r.expr(r.minval()).toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjQzIiwiT3JpZ2luYWwiOiJyLmV4cHIoci5tYXh2YWwpLnRvX2pzb25fc3RyaW5nKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5tYXh2YWwoKSkudG9Kc29uU3RyaW5nKCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0Nhbm5vdCBjb252ZXJ0IGByLm1heHZhbGAgdG8gSlNPTi4nKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJDYW5ub3QgY29udmVydCBgci5tYXh2YWxgIHRvIEpTT04uXCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #43
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.maxval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 /* Original: r.expr(r.maxval).to_json_string() */
                 var obtained = runOrCatch( r.expr(r.maxval()).toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjQ2IiwiT3JpZ2luYWwiOiJyLmV4cHIoci5taW52YWwpLmNvZXJjZV90bygnc3RyaW5nJykiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5taW52YWwoKSkuY29lcmNlVG8oXCJzdHJpbmdcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0Nhbm5vdCBjb252ZXJ0IGByLm1pbnZhbGAgdG8gSlNPTi4nKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJDYW5ub3QgY29udmVydCBgci5taW52YWxgIHRvIEpTT04uXCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #46
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.minval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 /* Original: r.expr(r.minval).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(r.minval()).coerceTo("string") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjQ5IiwiT3JpZ2luYWwiOiJyLmV4cHIoci5tYXh2YWwpLmNvZXJjZV90bygnc3RyaW5nJykiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5tYXh2YWwoKSkuY29lcmNlVG8oXCJzdHJpbmdcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0Nhbm5vdCBjb252ZXJ0IGByLm1heHZhbGAgdG8gSlNPTi4nKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJDYW5ub3QgY29udmVydCBgci5tYXh2YWxgIHRvIEpTT04uXCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #49
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.maxval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 /* Original: r.expr(r.maxval).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(r.maxval()).coerceTo("string") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjUyIiwiT3JpZ2luYWwiOiJyLnRpbWUoMjAxNCw5LDExLCAnWicpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici50aW1lKDIwMTRMLCA5TCwgMTFMLCBcIlpcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoieyd0aW1lem9uZSc6JyswMDowMCcsJyRyZXFsX3R5cGUkJzonVElNRScsJ2Vwb2NoX3RpbWUnOjE0MTAzOTM2MDB9IiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwidGltZXpvbmVcIiwgXCIrMDA6MDBcIikud2l0aChcIiRyZXFsX3R5cGUkXCIsIFwiVElNRVwiKS53aXRoKFwiZXBvY2hfdGltZVwiLCAxNDEwMzkzNjAwTCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W3siS2V5IjoidGltZV9mb3JtYXQiLCJWYWwiOiJyYXcifV0sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, json.yaml, #52
                 /* ExpectedOriginal: {'timezone':'+00:00','$reql_type$':'TIME','epoch_time':1410393600} */
                 var expected_ = r.hashMap("timezone", "+00:00").with("$reql_type$", "TIME").with("epoch_time", 1410393600L);
                 
                 /* Original: r.time(2014,9,11, 'Z') */
                 var obtained = runOrCatch( r.time(2014L, 9L, 11L, "Z") ,
                                            new {
                     time_format = "raw" ,
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjU3IiwiT3JpZ2luYWwiOiJyLnRpbWUoMjAxNCw5LDExLCAnWicpLnRvX2pzb25fc3RyaW5nKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnRpbWUoMjAxNEwsIDlMLCAxMUwsIFwiWlwiKS50b0pzb25TdHJpbmcoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7XCIkcmVxbF90eXBlJFwiOlwiVElNRVwiLFwiZXBvY2hfdGltZVwiOjE0MTAzOTM2MDAsXCJ0aW1lem9uZVwiOlwiKzAwOjAwXCJ9IiwiRXhwZWN0ZWRUeXBlIjoiU3RyaW5nIiwiRXhwZWN0ZWRKYXZhIjoiXCJ7XFxcIiRyZXFsX3R5cGUkXFxcIjpcXFwiVElNRVxcXCIsXFxcImVwb2NoX3RpbWVcXFwiOjE0MTAzOTM2MDAsXFxcInRpbWV6b25lXFxcIjpcXFwiKzAwOjAwXFxcIn1cIiIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, json.yaml, #57
                 /* ExpectedOriginal: {"$reql_type$":"TIME","epoch_time":1410393600,"timezone":"+00:00"} */
                 var expected_ = "{\"$reql_type$\":\"TIME\",\"epoch_time\":1410393600,\"timezone\":\"+00:00\"}";
                 
                 /* Original: r.time(2014,9,11, 'Z').to_json_string() */
                 var obtained = runOrCatch( r.time(2014L, 9L, 11L, "Z").toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjYwIiwiT3JpZ2luYWwiOiJyLnBvaW50KDAsMCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnBvaW50KDBMLCAwTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoieyckcmVxbF90eXBlJCc6J0dFT01FVFJZJywnY29vcmRpbmF0ZXMnOlswLDBdLCd0eXBlJzonUG9pbnQnfSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcIiRyZXFsX3R5cGUkXCIsIFwiR0VPTUVUUllcIikud2l0aChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoMEwsIDBMKSkud2l0aChcInR5cGVcIiwgXCJQb2ludFwiKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, json.yaml, #60
                 /* ExpectedOriginal: {'$reql_type$':'GEOMETRY','coordinates':[0,0],'type':'Point'} */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 0L)).with("type", "Point");
                 
                 /* Original: r.point(0,0) */
                 var obtained = runOrCatch( r.point(0L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjYzIiwiT3JpZ2luYWwiOiJyLnBvaW50KDAsMCkudG9fanNvbl9zdHJpbmcoKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucG9pbnQoMEwsIDBMKS50b0pzb25TdHJpbmcoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7XCIkcmVxbF90eXBlJFwiOlwiR0VPTUVUUllcIixcImNvb3JkaW5hdGVzXCI6WzAsMF0sXCJ0eXBlXCI6XCJQb2ludFwifSIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6Ilwie1xcXCIkcmVxbF90eXBlJFxcXCI6XFxcIkdFT01FVFJZXFxcIixcXFwiY29vcmRpbmF0ZXNcXFwiOlswLDBdLFxcXCJ0eXBlXFxcIjpcXFwiUG9pbnRcXFwifVwiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #63
                 /* ExpectedOriginal: {"$reql_type$":"GEOMETRY","coordinates":[0,0],"type":"Point"} */
                 var expected_ = "{\"$reql_type$\":\"GEOMETRY\",\"coordinates\":[0,0],\"type\":\"Point\"}";
                 
                 /* Original: r.point(0,0).to_json_string() */
                 var obtained = runOrCatch( r.point(0L, 0L).toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, json.yaml, #68
             //Original: s = b'\x66\x6f\x6f'
             
                 var s = (byte[]) (new byte[] { 102, 111, 111 });
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjcwIiwiT3JpZ2luYWwiOiJyLmJpbmFyeShzKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuYmluYXJ5KHMpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InMiLCJFeHBlY3RlZFR5cGUiOiJieXRlW10iLCJFeHBlY3RlZEphdmEiOiJzIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, json.yaml, #70
                 /* ExpectedOriginal: s */
                 var expected_ = s;
                 
                 /* Original: r.binary(s) */
                 var obtained = runOrCatch( r.binary(s) ,
                                            new {
                    }, conn);
                 
                     assertArrayEquals(expected_, obtained);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoianNvbi55YW1sIiwiTGluZU51bSI6IjczIiwiT3JpZ2luYWwiOiJyLmV4cHIoXCJmb29cIikuY29lcmNlX3RvKFwiYmluYXJ5XCIpLnRvX2pzb25fc3RyaW5nKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoXCJmb29cIikuY29lcmNlVG8oXCJiaW5hcnlcIikudG9Kc29uU3RyaW5nKCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoie1wiJHJlcWxfdHlwZSRcIjpcIkJJTkFSWVwiLFwiZGF0YVwiOlwiWm05dlwifSIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6Ilwie1xcXCIkcmVxbF90eXBlJFxcXCI6XFxcIkJJTkFSWVxcXCIsXFxcImRhdGFcXFwiOlxcXCJabTl2XFxcIn1cIiIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, json.yaml, #73
                 /* ExpectedOriginal: {"$reql_type$":"BINARY","data":"Zm9v"} */
                 var expected_ = "{\"$reql_type$\":\"BINARY\",\"data\":\"Zm9v\"}";
                 
                 /* Original: r.expr("foo").coerce_to("binary").to_json_string() */
                 var obtained = runOrCatch( r.expr("foo").coerceTo("binary").toJsonString() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
