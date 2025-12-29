const { sql, connection } = require("/config/Database")
const { Status } = require("/enum/Status")
const { Message } = require("/enum/Message")

module.exports = function () {

    this.findAll = async function(param, result) {
        const pool = await connection
        const query = "SELECT * FROM Matches"
        await pool.request()
            .query(query, function (error, data) {
                if(!error) {
                    result(Status.Ok, Message.Ok, data.recordset, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.create = async function(param, result) {
        const pool = await connection
        const query = "INSERT INTO Matches(id, firstClubId, secondClubId, firstScore, secondScore) " +
            "VALUES(@id, @firstClubId, @secondClubId, @firstScore, @secondScore)"
        await pool.request()
            .input("id", sql.Int, param.id)
            .input("firstClubId", sql.Int, param.firstClubId)
            .input("secondClubId", sql.Int, param.secondClubId)
            .input("firstScore", sql.Int, param.firstScore)
            .input("secondScore", sql.Int, param.secondScore)
            .query(query, function (error, data) {
                if(!error) {
                    result(Status.Created, Message.Created, data, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.delete = async function(param, result) {
        const pool = await connection
        const query = "DELETE FROM Matches WHERE id = @id"
        await pool.request()
            .input("id", sql.Int, param)
            .query(query, function (error, data) {
                if(!error) {
                    result(Status.NoContent, Message.NoContent, data, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }
}