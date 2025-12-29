const sql = require("mssql/msnodesqlv8")

const config = {
    server : "localhost",
    port : 1443,
    database : "FootballClub",
    driver : "msnodesqlv8",
    user : "sa",
    password : "139"
}

const connection = new sql.ConnectionPool(config).connect().then(pool => { return pool })

module.exports = {
    sql : sql,
    connection : connection
}