const { user } = require("/app/model/User")

exports.findById = function (req, res) {
    user.findById(req.params.id, function (status, message, data, error) {
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
    user.create(req.body, function (status, message, data, error) {
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