// Regression test for DevDiv:305886
// [QueryExpressions] Identifiers for range variables in for-join queries cannot be uppercase!
// We expect no warnings in this case.
//<Expects status="success"></Expects>

module M
// No warnings
let _ =
   query {
    for (A,B) in seq { for XA in [1..2] -> (XA,XA+1) } do
       join b in [1..2] on (A = b)
       select b
}

// No warnings
let _ =
   query {
    for (表a,B) in seq { for 表表 in [1..2] -> (表表,表表+1) } do
       join b in [1..2] on (表a = b)
       select b
}