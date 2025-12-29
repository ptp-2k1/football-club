const { club } = require("/app/model/Club")

exports.findAll = function (req, res) {
    club.findAll(null, function (status, message, data, error) {
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

exports.findById = function (req, res) {
    club.findById(req.params.id, function (status, message, data, error) {
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
    club.create(req.body, function (status, message, data, error) {
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

exports.update = function (req, res) {
    club.update(req.body, function (status, message, data, error) {
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
    club.delete(req.params.id, function (status, message, data, error) {
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