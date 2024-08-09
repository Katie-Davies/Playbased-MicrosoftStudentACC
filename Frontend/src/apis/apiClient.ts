import request from 'superagent'

const rootUrl = 'http://localhost:5091/api'

export async function getAllUsers() {
  const users = await request.get(`${rootUrl}/users`)
  return users.body
}

export async function getUserById(id: string) {
  const user = await request.get(`${rootUrl}/users/${id}`)
  return user.body
}
