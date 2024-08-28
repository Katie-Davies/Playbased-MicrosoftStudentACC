import SmallCard from '../components/smallCard'
import { useGetActivitiesByAge } from '../hooks/useGetActivitiesByAge'
import { Activity } from '../models/models'

function ActivitiesByAge({ selectedId }: { selectedId: number }) {
  const { data: activitiesByAge, isLoading: activitiesByAgeLoading } =
    useGetActivitiesByAge(selectedId)

  if (activitiesByAgeLoading) {
    return <div>Loading...</div>
  }

  console.log(activitiesByAge)

  return (
    <div className="flex justify-around flex-wrap">
      {activitiesByAge?.map((activity: Activity) => (
        <SmallCard
          key={activity.activityId}
          title={activity.activityName}
          description={activity.description}
          ageGroupID={activity.ageGroupID}
          categoryID={activity.categoryID}
          materials={activity.materials}
          imgurl={activity.imageUrl}
          id={activity.activityId}
        />
      ))}
    </div>
  )
}

export default ActivitiesByAge
