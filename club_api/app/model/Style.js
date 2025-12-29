const { sql, connection } = require("/config/Database")
const { Status } = require("/enum/Status")
const { Message } = require("/enum/Message")

module.exports = function () {

    this.findAllByClubId = async function (param, result) {
        const pool = await connection
        const query = "SELECT * FROM Styles WHERE clubId = @param"
        await pool.request()
            .input("clubId", sql.Int, param)
            .query(query, function (error, data) {
                if(!error) {
                    if(data.recordset.length > 0) {
                        result(Status.Ok, Message.Ok, data.recordset, null)
                    } else {
                        result(Status.NotFound, Message.NotFound, null, null)
                    }
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.create = async function(param, result) {
        const pool = await connection
        const query = "INSERT INTO Styles(id, clubId, name) VALUES(@id, @clubId, @name)"
        await pool.request()
            .input("id", sql.Int, param.id)
            .input("clubId", sql.Int, param.clubId)
            .input("name", sql.VarChar, param.name)
            .query(query, function (error, data) {
                if(!error) {
                    result(Status.Created, Message.Created, data, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.delete = async function (param, result) {
        const pool = await connection
        const query = "DELETE FROM Styles WHERE id = @id"
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