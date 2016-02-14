












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

    public partial class OuterJoin : ReqlExpr {

    
    
    
/// <summary>
/// <para>Returns a left outer join of two sequences.</para>
/// </summary>
/// <example><para>Example: Return a list of all Marvel heroes, paired with any DC heroes who could beat them in a fight.</para>
/// <code>r.table('marvel').outerJoin(r.table('dc'), function(marvelRow, dcRow) {
///     return marvelRow('strength').lt(dcRow('strength'))
/// }).run(conn, callback)
/// </code></example>
        public OuterJoin (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Returns a left outer join of two sequences.</para>
/// </summary>
/// <example><para>Example: Return a list of all Marvel heroes, paired with any DC heroes who could beat them in a fight.</para>
/// <code>r.table('marvel').outerJoin(r.table('dc'), function(marvelRow, dcRow) {
///     return marvelRow('strength').lt(dcRow('strength'))
/// }).run(conn, callback)
/// </code></example>
        public OuterJoin (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Returns a left outer join of two sequences.</para>
/// </summary>
/// <example><para>Example: Return a list of all Marvel heroes, paired with any DC heroes who could beat them in a fight.</para>
/// <code>r.table('marvel').outerJoin(r.table('dc'), function(marvelRow, dcRow) {
///     return marvelRow('strength').lt(dcRow('strength'))
/// }).run(conn, callback)
/// </code></example>
        public OuterJoin (Arguments args, OptArgs optargs)
         : base(TermType.OUTER_JOIN, args, optargs) {
        }


    



    


    

    


    
    }
}
