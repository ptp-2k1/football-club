const styleController = require("/app/controller/StyleController")
const entry = "/api/style"

module.exports = function (app) {
    app.get(entry + "/:id", styleController.findAllByClubId)
    app.post(entry, styleController.create)
    app.delete(entry + "/:id", styleController.delete)
}