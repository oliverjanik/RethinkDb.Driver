












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class InTimezone : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return a new time object with a different timezone. While the time stays the same, the results returned by methods such as hours() will change since they take the timezone into account. The timezone argument has to be of the ISO 8601 format.</para>
/// </summary>
/// <example><para>Example: Hour of the day in San Francisco (UTC/GMT -8, without daylight saving time).</para>
/// <code>r.now().inTimezone('-08:00').hours().run(conn, callback)
/// </code></example>
        public InTimezone (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return a new time object with a different timezone. While the time stays the same, the results returned by methods such as hours() will change since they take the timezone into account. The timezone argument has to be of the ISO 8601 format.</para>
/// </summary>
/// <example><para>Example: Hour of the day in San Francisco (UTC/GMT -8, without daylight saving time).</para>
/// <code>r.now().inTimezone('-08:00').hours().run(conn, callback)
/// </code></example>
        public InTimezone (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return a new time object with a different timezone. While the time stays the same, the results returned by methods such as hours() will change since they take the timezone into account. The timezone argument has to be of the ISO 8601 format.</para>
/// </summary>
/// <example><para>Example: Hour of the day in San Francisco (UTC/GMT -8, without daylight saving time).</para>
/// <code>r.now().inTimezone('-08:00').hours().run(conn, callback)
/// </code></example>
        public InTimezone (Arguments args, OptArgs optargs)
         : base(TermType.IN_TIMEZONE, args, optargs) {
        }


    



    


    

    


    
    }
}
