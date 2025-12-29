const matchController = require("/app/controller/MatchController")
const entry = "/api/match"

module.exports = function (app) {
    app.get(entry, matchController.findAll)
    app.post(entry, matchController.create)
    app.delete(entry + "/:id", matchController.delete)
}