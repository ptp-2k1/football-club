const { sql, connection } = require("/config/Database")
const { Status } = require("/enum/Status")
const { Message } = require("/enum/Message")

module.exports = function () {

    this.findAll = async function(param, result) {
        const pool = await connection
        const query = "SELECT * FROM Clubs"
        await pool.request()
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

    this.findById = async function(param, result) {
        const pool = await connection
        const query = "SELECT TOP 1 * FROM Clubs WHERE id = @id"
        await pool.request()
            .input("id", sql.Int, param)
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
        const query = "INSERT INTO Clubs(id, name, league, tournament) VALUES(@id, name, league, tournament)"
        await pool.request()
            .input("id", sql.Int, param.id)
            .input("name", sql.VarChar, param.name)
            .input("league", sql.VarChar, param.league)
            .input("tournament", sql.VarChar, param.tournament)
            .query(query, function (error, data) {
                if(!error) {
                    result(Status.Created, Message.Created, data, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.update = async function(param, result) {
        const pool = await connection
        const query = "UPDATE Clubs SET name=@name, league=@league, tournament=@tournament WHERE id=@id"
        await pool.request()
            .input("name", sql.VarChar, param.name)
            .input("league", sql.VarChar, param.league)
            .input("tournament", sql.VarChar, param.tournament)
            .input("id", sql.Int, param.id)
            .query(query, function (error, data) {
                if(!error) {
                    result(!Status.NoContent, Message.NoContent, data, null)
                } else {
                    result(Status.InternalServerError, Message.InternalServerError, null, error)
                }
            })
    }

    this.delete = async function(param, result) {
        const pool = await connection
        const query = "DELETE FROM Clubs WHERE id=@id"
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