export interface User {
  id?: number
  username: string
  email: string
}

export interface Activity {
  activityId: number
  activityName: string
  description: string
  materials: string
  ageGroupID: number
  categoryID: number
  imageUrl: string
}

export interface Favourite {
  id?: number
  userId: number
  activityId: number
  activityName: string
  imageUrl: string
  activity: object
}

export interface Material {
  materialID: number
  materialName: string
}
