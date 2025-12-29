const { match } = require("/app/model/Match")

exports.findAll = function (req, res) {
    match.findAll(null, function (status, message, data, error) {
        res.send({
            status : status,
            message : message,
            data : data,
            error : error
        }).then(value => {
            console.log(value)
        })
    })
}

exports.create = function (req, res) {
    match.create(req.body, function (status, message, data, error) {
        res.send({
            status : status,
            message : message,
            data : data,
            error : error
        }).then(value => {
            console.log(value)
        })
    })
}

exports.delete = function (req, res) {
    match.delete(req.params.id, function (status, message, data, error) {
        res.send({
            status : status,
            message : message,
            data : data,
            error : error
        }).then(value => {
            console.log(value)
        })
    })
}