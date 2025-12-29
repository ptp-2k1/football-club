const clubController = require("/app/controller/ClubController")
const entry = "/api/club"

module.exports = function (app) {
    app.get(entry, clubController.findAll)
    app.get(entry + "/:id", clubController.findById)
    app.post(entry, clubController.create)
    app.put(entry + "/:id", clubController.update)
    app.delete(entry + "/:id", clubController.delete)
}