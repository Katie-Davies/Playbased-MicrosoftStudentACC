import request from 'superagent'
import { Favourite, User } from '../models/models'

const rootUrl = 'http://localhost:5091/api'

// User Requests
export async function getAllUsers() {
  const users = await request.get(`${rootUrl}/users`)
  return users.body
}

export async function getUserById(id: number) {
  const user = await request.get(`${rootUrl}/users/${id}`)
  return user.body
}

export async function createUser(user: User) {
  const newUser = await request.post(`${rootUrl}/users`).send(user)
  return newUser.body
}

export async function deleteUser(id: number) {
  return await request.del(`${rootUrl}/users/${id}`)
}

// Activity requests

export async function getAllActivities() {
  const activities = await request.get(`${rootUrl}/activities`)
  return activities.body
}

export async function getActivitiesByAgeGroup(ageId: number) {
  const activities = await request.get(
    `${rootUrl}/activities/agegroup/${ageId}`
  )
  return activities.body
}

export async function getActivityByMaterial(material: string) {
  const activities = await request.get(
    `${rootUrl}/activities/materials/${material}`
  )
  return activities.body
}

//favourites request
//get
export async function getAllFavourites(userId: number) {
  const favourites = await request.get(`${rootUrl}/favourites/${userId}`)
  return favourites.body
}
//add
export async function addFavourite(favourite: Favourite) {
  const addedFavourite = await request
    .post(`${rootUrl}/favourites`)
    .send(favourite)
  return addedFavourite.body
}
//delete
export async function deleteFavourite(id: number) {
  return await request.del(`${rootUrl}/favourites/${id}`)
}
