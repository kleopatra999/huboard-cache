module hucache.tests

open Xunit

let add x y = x + y // unit

[<Fact>]   // test
let add_5_to_3_should_be_8() =
    let a = hucache.http.caches.postgres.convertHerokuUrl "postgres://user3123:passkja@ec2-117-21-174-214.compute-1.amazonaws.com:6212/db982398"
    let e = "User ID=user3123;Password=passkja;Host=ec2-117-21-174-214.compute-1.amazonaws.com;Port=6212;Database=db982398;Pooling=false;"
    Assert.Equal(e, a)