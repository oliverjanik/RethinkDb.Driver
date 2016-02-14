












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

    public partial class DbList : ReqlExpr {

    
    
    
/// <summary>
/// <para>List all database names in the system. The result is a list of strings.</para>
/// </summary>
/// <example><para>Example: List all databases.</para>
/// <code>r.dbList().run(conn, callback)
/// </code></example>
        public DbList (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>List all database names in the system. The result is a list of strings.</para>
/// </summary>
/// <example><para>Example: List all databases.</para>
/// <code>r.dbList().run(conn, callback)
/// </code></example>
        public DbList (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>List all database names in the system. The result is a list of strings.</para>
/// </summary>
/// <example><para>Example: List all databases.</para>
/// <code>r.dbList().run(conn, callback)
/// </code></example>
        public DbList (Arguments args, OptArgs optargs)
         : base(TermType.DB_LIST, args, optargs) {
        }


    



    


    

    


    
    }
}
