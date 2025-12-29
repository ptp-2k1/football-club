const { sql, connection } = require("/config/Database")
const { Status } = require("/enum/Status")
const { Message } = require("/enum/Message")

module.exports = function () {

    this.findById = async function(param, result) {
        const pool = await connection
        const query = "SELECT TOP 1 * FROM Users WHERE id = @id"
        await pool.request()
            .input("id", sql.Int, param)
            .query(query, function (error, data) {
                if(!error) {
                    if(data.recordset.length > 0) {
                        result(Status.Ok, Message.Ok, data.recordset[0], null)
                    } else {
                        result(Status.NotFound, Message.NotFound, null, null)
                    }
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.create = async function(param, result) {
        const pool = await  connection
        const query = "INSERT INTO Users(id, userName, password) VALUES(@id, @userName, @password)"
        await pool.request()
            .input("id", sql.Int, param.id)
            .input("userName", sql.VarChar, param.userName)
            .input("password", sql.VarChar, param.password)
            .query(query, function (error, data) {
                if(!error) {
                    result(Status.Created, Message.Created, data, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }
}