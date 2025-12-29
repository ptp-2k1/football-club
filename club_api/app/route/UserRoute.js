const userController = require("/app/controller/UserController")
const entry = "/api/user"

module.exports = function (app) {
    app.get(entry + "/:id", userController.findById)
    app.post(entry, userController.create)
}