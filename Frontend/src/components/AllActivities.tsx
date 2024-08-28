import SmallCard from '../components/smallCard'
import { useGetAllActivities } from '../hooks/useGetAllActivities'
import { Activity } from '../models/models'

function AllActivities() {
  const { data: allActivities, isLoading: allActivitiesLoading } =
    useGetAllActivities()

  if (allActivitiesLoading) {
    return <div>Loading...</div>
  }
  console.log(allActivities)
  const activities = allActivities[0]
  console.log(activities.length)

  return (
    <div className="flex justify-around flex-wrap">
      {allActivities?.map(
        (activity: Activity) => (
          console.log(activity),
          (
            <SmallCard
              key={activity.activityId}
              title={activity.activityName}
              description={activity.description}
              ageGroupID={activity.ageGroupID}
              categoryID={activity.categoryID}
              imgurl={activity.imageUrl}
              id={activity.activityId}
            />
          )
        )
      )}
    </div>
  )
}

export default AllActivities