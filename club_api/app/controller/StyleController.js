const { style } = require("/app/model/Style")

exports.findAllByClubId = function (req, res) {
    style.findAllByClubId(req.params.id, function (status, message, data, error) {

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
    style.create(req.body, function (status, message, data, error) {
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
    style.delete(req.params.id, function (status, message, data, error) {
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